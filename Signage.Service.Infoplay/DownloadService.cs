using Abp.Dependency;
using Castle.Core.Logging;
using Newtonsoft.Json;
using Signage.Service.Infoplay;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Signage.Service
{
    public class DownloadService : ISingletonDependency
    {
        public ILogger loger { get; set; }
        private bool IsRuning = false;
        private Task task;

        private InfoplayConfig _infoplayConfig;

        private ConcurrentDictionary<string, DownloadServiceItem> downloadServiceItem_Repo = new ConcurrentDictionary<string, DownloadServiceItem>();
        private ConcurrentQueue<string> cqFileWatchEvent = new ConcurrentQueue<string>();
        public DownloadService(InfoplayConfig infoplayConfig)
        {
            _infoplayConfig = infoplayConfig;
        }

        public void Start()
        {
            if (IsRuning) return;
            IsRuning = true;
            //启动后台线程
            task = Task.Factory.StartNew(() =>
              {
                  Process();
              });
            //process file change event que
            Task.Factory.StartNew(() =>
            {
                string downloadConfigFileName;
                while (IsRuning)
                {
                    if (cqFileWatchEvent.IsEmpty) Thread.Sleep(1000);

                    if (!cqFileWatchEvent.TryPeek (out downloadConfigFileName)) continue;
                    try
                    {
                        AddDownloadServiceItem(downloadConfigFileName);
                        cqFileWatchEvent.TryDequeue(out downloadConfigFileName);


                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(1000);
                    }
                }

            });
        }
        public void Stop()
        {
            IsRuning = false;
            task.Wait();
            task = null;
        }

        private void Process()
        {
            try
            {
                foreach (var WatcherPath in _infoplayConfig.WatcherPaths)
                {
                    Watch(WatcherPath);
                }
                loger.Info("FileWatcher Service started ...");
                while (IsRuning)
                {

                    bool IsNeedSleep = true;
                    int rc = 0;
                    try
                    {
                        Stopwatch sw1 = Stopwatch.StartNew();

                        rc = rc + DO_Process();
                        rc = rc + DO_Update();

                        if (rc > 0)
                        {
                            IsNeedSleep = false;
                        }

                        DO_CheckWatcherPaths();

                    }
                    catch (Exception ex)
                    {

                        loger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
                    }

                    if (IsNeedSleep) Thread.Sleep(3000);
                }
            }
            catch (Exception ex)
            {

                loger.Error(ex.Message);
            }
        }

        private object DO_Process_LOCK = new object();
        private int DO_Process()
        {
            return 0;
        }

        private int DO_Update()
        {
            return 0;
        }

        private DateTime last_DO_CheckWatcherPathsTime = DateTime.Now.AddDays(-1);

        private void DO_CheckWatcherPaths()
        {
            var ts = DateTime.Now - last_DO_CheckWatcherPathsTime;
            if (ts.TotalMinutes < 60) return;
            last_DO_CheckWatcherPathsTime = DateTime.Now;

            Task.Factory.StartNew(() =>
            {

                foreach (var WatcherPath in _infoplayConfig.WatcherPaths)
                {
                    if (Directory.Exists(WatcherPath))
                    {
                        DO_CheckWatcherDir(WatcherPath);
                    }
                    else
                    {
                        DO_CheckWatcherFile(WatcherPath);
                    }
                }
            });
        }
        private void DO_CheckWatcherDir(string dirName)
        {
            foreach(var dn in Directory.GetDirectories(dirName))
            {
                DO_CheckWatcherDir(dn);
            }

            foreach (var fn in Directory.GetFiles(dirName))
            {
                DO_CheckWatcherFile(fn);
            }

        }
        private void DO_CheckWatcherFile(string fileName)
        {
            var downloadConfigFileName = Path.GetFileName(fileName);

            if (string.Compare(downloadConfigFileName, "downloadConfig.json", true) != 0) return;
            var keyString = ".program";
            var programRoot = Path.GetDirectoryName(fileName);
            if (!programRoot.EndsWith(keyString)) return;

            AddDownloadServiceItem(fileName);
        }
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void Watch(string watcherPath)
        {
            try
            {

                loger.Info($"{watcherPath} is watching...");
                // Create a new FileSystemWatcher and set its properties.
                FileSystemWatcher watcher = new FileSystemWatcher();

                watcher.Path = watcherPath;

                // Watch for changes in LastAccess and LastWrite times, and
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastWrite
                                     | NotifyFilters.FileName;
                //| NotifyFilters.Size;

                // Only watch text files.
                watcher.Filter = "downloadConfig.json";
                watcher.IncludeSubdirectories = true;

                // Add event handlers.
                watcher.Changed += OnChanged;
                watcher.Created += OnChanged;
                watcher.Deleted += OnChanged;
                watcher.Renamed += OnRenamed;

                // Begin watching.
                watcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                loger.Error(System.Reflection.MethodBase.GetCurrentMethod().Name, ex);
            }
        }
        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e)
        {

            OnChangedProcess(e.FullPath);
        }

        private void OnRenamed(object source, RenamedEventArgs e)
        {

            OnChangedProcess(e.FullPath);
        }

        private void OnChangedProcess(string fileName)
        {
            cqFileWatchEvent.Enqueue(fileName);

            

        }

     
        private void AddDownloadServiceItem(string downloadConfigFileName)
        {
            var fileName = downloadConfigFileName;

            var keyString = ".program";
            var programRoot = Path.GetDirectoryName(fileName);
            if (!programRoot.EndsWith(keyString)) return;

            var len = programRoot.Length - keyString.Length - 1;
            programRoot = programRoot.Substring(0, len);

            var str = File.ReadAllText(fileName);
            var config = JsonConvert.DeserializeObject<DownloadConfig>(str);


            foreach (var di in config.DownloadItems)
            {
                DownloadServiceItem dsi;
                if (!downloadServiceItem_Repo.TryGetValue(di.Uri, out dsi))
                {
                    dsi = new DownloadServiceItem(di.Uri);
                    downloadServiceItem_Repo.TryAdd(di.Uri, dsi);
                }

                dsi.AddSaveFile(programRoot, di);
                var tempFileName=dsi.GetTempFileName();
            }

        }
    }

}