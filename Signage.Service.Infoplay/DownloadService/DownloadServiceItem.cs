using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Signage.Service.Infoplay

{

    public class DownloadServiceItem
    {

        public static InfoplayConfig infoplayConfig { get; set; }
        public static DownloadServiceConfig downloadServiceConfig { get; set; }
        const int IsUsed_Timeout_Seconds = 150;
        // private static ILog loger = LogManager.GetLogger(typeof(DownloadItem));
        public static long NeedCheckMD5_MaxContentSize = 1024000L;

        /// <summary>
        /// 检查下载优先级，0最低
        /// </summary>

        private int priorLevel = 0;
        public int PriorLevel
        {
            get { return priorLevel; }

        }

        public bool UpdatePriorLevel(string[] priorKeys)
        {
            bool rc = false;
            priorLevel = 0;
            foreach (var key in priorKeys)
            {
                if (_uri.Contains(key))
                {
                    rc = true;
                    priorLevel = 1;
                    break;
                }
            }
            return rc;
        }


        private int intervalSeconds = 300;
        public int IntervalSeconds
        {
            get { return intervalSeconds; }
            set
            {
                if (value <= 0) return;
                if (value >= intervalSeconds) return;
                intervalSeconds = value;

            }
        }

        private string _uri;
        public string Uri
        {
            get { return _uri; }
        }

        private string _downloadUri = "";
        public string DownloadUri
        {
            get
            {
                if (string.IsNullOrEmpty(_downloadUri))
                {
                    _downloadUri = downloadServiceConfig.GetDestUri(_uri);
                }
                return _downloadUri;
            }
        }

        private MediaTypeHeaderValue contentType;

        private string mediaType
        {
            get
            {
                if (contentType == null) return "text";
                if (contentType.MediaType == null) return "text";
                return contentType.MediaType.ToLower();
            }
        }
        private DateTime? contentLastModified;
        public DateTime? ContentLastModified
        {
            get
            {
                return contentLastModified;
            }
        }

        private long? contentLength;
        public long? ContentLength
        {
            get { return contentLength; }
        }

        private string md5;
        public string MD5
        {
            get { return md5; }
            set { md5 = value; }
        }

        private int? pt_ss;//默认不存在PT_SS参数
        public int? PT_SS
        {
            get { return pt_ss; }
            set { pt_ss = value; }
        }



        private DateTime lastCheckTime;
        public DateTime LastCheckTime
        {
            get
            {
                return lastCheckTime;
            }
            set
            {
                lastCheckTime = value;
            }
        }

        private int checkCounter = 0;
        public int CheckCounter { get { return checkCounter; } }


        private int errorCounter = 0;
        public int ErrorCounter { get { return errorCounter; } }


        private string errorMsg = "";
        public string ErrorMsg { get { return errorMsg; } }


        private DateTime lastChangeTime;
        public DateTime LastChangeTime
        {
            get { return lastChangeTime; }
        }

        private int changeCounter = 0;
        public int ChangeCounter
        {
            get { return changeCounter; }
        }

        private long procDuration;
        public long ProcDuration
        {
            get { return procDuration; }
        }
        private bool isPublish = false;
        public bool IsPublish
        {
            get
            {

                return isPublish;
            }
            set
            {
                isPublish = value;
                if (isPublish)
                {
                    this.lastCheckTime = DateTime.Now.AddHours(-1);
                }
            }
        }
        public bool IsUsed
        {
            get
            {


                //是否过时没有引用了
                bool rc = (DateTime.Now - lastUsedTime).TotalSeconds < IsUsed_Timeout_Seconds;
                return rc;
            }
            set
            {

                if (value)
                {
                    lastUsedTime = DateTime.Now;
                }

            }
        }

        private DateTime lastUsedTime;
        public DateTime LastUsedTime
        {
            get { return lastUsedTime; }
        }

        public DownloadServiceItem(string url)
        {
            IntervalSeconds = intervalSeconds;

            _uri = url;

        }

        private string _tempFileName;
        private string tempFileName
        {
            get
            {
                if (string.IsNullOrEmpty(_tempFileName))
                {
                  
                    if (!Directory.Exists(downloadServiceConfig.TempDownloadRoot))
                    {
                        Directory.CreateDirectory(downloadServiceConfig.TempDownloadRoot);
                    }
                    var fn = MD5Code.StringMD5(_uri) + ".tmp";

                    _tempFileName = Path.GetFullPath(Path.Combine(downloadServiceConfig.TempDownloadRoot, fn));
                }

                return _tempFileName;
            }
        }

        private Dictionary<string, DownloadSaveFile> SaveFiles = new Dictionary<string, DownloadSaveFile>();

        public void AddSaveFile(string programRoot, DownloadConfigItem configItem)
        {

            this.IntervalSeconds = configItem.IntervalSecs;

            DownloadSaveFile saveFile = new DownloadSaveFile();
            saveFile.ProgramRoot = programRoot;
            saveFile.FileName = configItem.FileName;
            saveFile.SaveType = configItem.SaveType;

            var key = saveFile.GetFullFileName();
            SaveFiles.TryAdd(key, saveFile);
        }
        private DateTime? ToDateTime(DateTimeOffset? dateTimeOffset)
        {
            if (!dateTimeOffset.HasValue) return null;
            return dateTimeOffset.Value.DateTime;
        }
        private bool IsNeedCheckMD5
        {
            get
            {
                if (contentLength > NeedCheckMD5_MaxContentSize) return false;
                if (mediaType.Contains("text")) return true;  // *.html *.xml
                if (mediaType.Contains("xml")) return true;  // *.html *.xml
                if (mediaType.Contains("htm")) return true;  // *.html *.xml
                if (mediaType.Contains("json")) return true;  // *.json
                if (mediaType.Contains("javascript")) return true; // *.js
                return false;
            }
        }
        private bool IsNeedCheck_PT_SS
        {
            get
            {

                if (mediaType.Contains("text")) return true;  // *.html *.xml
                if (mediaType.Contains("xml")) return true;  // *.html *.xml
                if (mediaType.Contains("htm")) return true;  // *.html *.xml
                if (mediaType.Contains("json")) return true;  // *.json
                if (mediaType.Contains("javascript")) return true; // *.js
                //if (this.contentType.CharSet.ToUpper() != "UTF-8") return false;
                return false;
            }
        }
        private int? Search_PT_SS(MemoryStream ms)
        {

            int? rc = new Nullable<int>();
            ms.Position = 0;
            string content = Encoding.UTF8.GetString(ms.ToArray());
            return Search_PT_SS(content);
        }

        private int? Search_PT_SS(string content)
        {
            int? rc = new Nullable<int>();
            string pattern = "PT_SS\\s*\"\\s*:\\s*null";
            Match match = Regex.Match(content, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            if (match.Success) return rc;

            pattern = "PT_SS\\s*\"\\s*:\\s*(\\d+)";
            match = Regex.Match(content, pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            if (match.Success)
            {
                var c = match.Groups[1].Captures[0];
                string value = c.Value;
                rc = int.Parse(c.Value);
            }
            return rc;
        }
     
        
        async public Task<bool> DownloadAsync()
        {
            var ts = DateTime.Now - this.lastCheckTime;
            if (ts.TotalSeconds < this.intervalSeconds) return false;

            bool isChanged = false;
            string oldMD5 = this.MD5;
            this.checkCounter++;
            this.lastCheckTime = DateTime.Now;
            Stopwatch sw = Stopwatch.StartNew();
            Exception error = null;
            using (var httpClient = new HttpClient())
            {
                try
                {

                    HttpResponseMessage respone = await httpClient.GetAsync(DownloadUri);
                    respone.EnsureSuccessStatusCode();
                    HttpContent httpContent = respone.Content;
                    HttpContentHeaders contentHeaders = httpContent.Headers;
                    HttpResponseHeaders responseHeaders = respone.Headers;

                    if (this.contentLength != contentHeaders.ContentLength)
                    {
                        isChanged = true;

                    }
                    else if (contentLastModified != ToDateTime(contentHeaders.LastModified))
                    {
                        isChanged = true;

                    }
                    this.contentLength = contentHeaders.ContentLength;
                    this.contentLastModified = ToDateTime(contentHeaders.LastModified);
                    this.contentType = contentHeaders.ContentType;

                    using (MemoryStream ms = new MemoryStream())
                    {
                        if (IsNeedCheckMD5)
                        {
                            await httpContent.CopyToAsync(ms);
                            string newMD5 = MD5Code.StreamMD5(ms);
                            if (this.md5 != newMD5)
                            {
                                this.md5 = newMD5;
                                isChanged = true;

                            }

                        }//IsNeedCheckMD5

                        if (isChanged)
                        {
                            this.lastChangeTime = DateTime.Now;
                            changeCounter++;

                            if (ms.Length > 0) //已经下载过
                            {
                                if (IsNeedCheck_PT_SS)
                                {
                                    this.pt_ss = Search_PT_SS(ms);
                                    /**
                                    if (this.pt_ss != ptss)
                                    {

                                        this.pt_ss = ptss;
                                    }
                                     * **/
                                }//IsNeedCheck_PT_SS
                                ms.Position = 0;
                                using (FileStream fs = File.Create(tempFileName))
                                {
                                    ms.Position = 0;
                                    ms.WriteTo(fs);
                                }
                            }//(ms.Length > 0)
                            else // 
                            {
                                using (FileStream fs = File.Create(tempFileName))
                                {
                                    await httpContent.CopyToAsync(fs);
                                }
                                //long len = await transfer.DownloadAsync(new Uri(this.Uri), this.SaveFileName, httpClient);
                            }
                        }//(isChanged)

                        errorCounter = 0;
                    }// using (MemoryStream ms

                }
                catch (Exception ex)
                {
                    error = ex;

                    errorCounter++;
                    if (errorCounter > 20) errorCounter = 20;
                    errorMsg = ex.Message;
                    this.lastCheckTime = DateTime.Now.AddSeconds(errorCounter * 60); //推迟下次请求时间
                    //loger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                }
                //NotifyResult(transfer, downloadNotify, isChanged, error); //update by hua
                //this.NotifyResultAsync(transfer, downloadNotify, isChanged, error);
                if (isChanged)
                {
                    foreach (var dsf in SaveFiles.Values)
                    {
                        await dsf.FromAsync(this.tempFileName);
                    }
                }
                sw.Stop();
                this.procDuration = (long)sw.Elapsed.TotalMilliseconds;

                return isChanged;
            }//using httpclient
        }



    }

}
