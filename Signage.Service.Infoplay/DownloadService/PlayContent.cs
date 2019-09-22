using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Signage.Service
{
    public class PlayContent
    {
        public string title { get; set; }
        public ContentType type { get; set; }
        public string content { get; set; }

    }

    public enum ContentType
    {
        Text = 1,
        File = 2

    }
    public static class PlayContentExtentions
    {
        public static List<PlayContent> GetPlayContentFromFile(this string fullFileName)
        {
            var content = File.ReadAllText(fullFileName);
            List<PlayContent> rc = new List<PlayContent>();
            //Regex r = new Regex(@"PT_SS.*?:(\d*)", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex r = new Regex(@".*?playContent.*?=.*?({.+?})", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            //"playTime={\"PT_SS\":30}; alertMode={\"alertMode\":\"0402\"}; "
            MatchCollection mc = r.Matches(content);
            foreach (Match m in mc)
            {

                string str0 = m.Groups[0].Value;
                string str = m.Groups[1].Value;
                try
                {
                    PlayContent pc = JsonConvert.DeserializeObject<PlayContent>(str);
                    switch (pc.type)
                    {
                        case ContentType.File:

                            break;
                        default:
                            break;
                    }
                    rc.Add(pc);
                }
                catch (Exception e)
                {
                    throw e;
                }

            }
            return rc;
        }


        private void SaveText(string title, PlayContent[] textContents)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var p in textContents)
            {
                if (p.type == ContentType.Text)
                {
                    sb.Append(p.content);
                }
            }
            string dfn = Path.Combine(filePlayerRoot, title) + ".txt";
            TryWriteText(dfn, sb.ToString());
        }

        private void TryWriteText(string fileName, string content)
        {
            int retrys = 0;
            while (retrys < 1000)
            {
                retrys++;
                try
                {
                    File.WriteAllText(fileName, content);
                    break;
                }
                catch (Exception e)
                {

                }
                Thread.Sleep(10);
            }
        }

        private void SaveFiles(string title, string imageExtend, int MaxImages, PlayContent[] fileContents)
        {
            List<string> fileNames = new List<string>();

            foreach (var p in fileContents)
            {
                if (p.type == ContentType.File)
                {
                    string[] fns = p.content.Split(new char[] { '|' });
                    fileNames.AddRange(fns);

                }
            }

            string[] distinctFiles = (from fn in fileNames
                                      where (File.Exists(fn))
                                      select fn).Distinct()
                                    .ToArray();

            int count = distinctFiles.Count();
            for (int index = 0; index < MaxImages; index++)
            {
                string sfn;
                string dfn = Path.Combine(filePlayerRoot, string.Format("{0}_{1}", title, index));
                if (count <= 0)
                {
                    sfn = "";
                    dfn = dfn + imageExtend;
                }
                else
                {

                    sfn = distinctFiles[index % count];
                    dfn = dfn + Path.GetExtension(sfn);
                }
                TryCopyFile(sfn, dfn);

            }
        }

        private void TryCopyFile(string sourceFileName, string destFileName)
        {
            int retrys = 0;

            while (retrys < 1000)
            {
                retrys++;
                try
                {
                    if (File.Exists(sourceFileName))
                    {
                        File.Copy(sourceFileName, destFileName, true);
                    }
                    else
                    {
                        File.Create(destFileName);
                    }
                    break;
                }
                catch (IOException e)
                {
                    Thread.Sleep(10);
                }
            }
        }
        private void PurgeFiles(string homeDirectory, string title)
        {
            foreach (var pathName in Directory.GetFiles(homeDirectory))
            {
                var fileName = Path.GetFileName(pathName);
            }

        }

    }
}
