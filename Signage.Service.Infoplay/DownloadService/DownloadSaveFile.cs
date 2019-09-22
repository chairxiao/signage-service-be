using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Signage.Service
{
    /// <summary>
    /// 
    /// </summary>
    public class DownloadSaveFile
    {
        public string ProgramRoot { get; set; }
        public string FileName { get; set; }
        public string SaveType { get; set; }

    }

    public static class DownloadSaveItemExtensions
    {
        public static string GetFullFileName(this DownloadSaveFile saveItem)
        {
            var fn = Path.Combine(saveItem.ProgramRoot, saveItem.FileName);
            return Path.GetFullPath(fn);
        }

        public static async Task FromAsync(this DownloadSaveFile saveItem, string srcFullFileName)
        {

            var dfn = saveItem.GetFullFileName();
            var dir = Path.GetDirectoryName(dfn);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            switch (saveItem.SaveType)
            {
                case "FilePlay":

                    FilePlay(srcFullFileName, dfn);
                    break;
                default:
                    await CopyAsync(srcFullFileName, dfn);
                    break;
            }

        }

        private static async Task CopyAsync(string srcFileName, string destFileName)
        {
            using (FileStream sfs = File.OpenRead(srcFileName))
            {

                using (FileStream dfs = File.Create(destFileName))
                {
                    await sfs.CopyToAsync(dfs);
                }
            }
        }

        private static void FilePlay(string srcFileName, string destFileName)
        {
            var playContents = srcFileName.GetPlayContentFromFile();
            foreach(var pc in playContents)
            {
                switch (pc.type)
                {
                    case ContentType.Text:
                        break;
                    case ContentType.File:
                        break;
                }
            }
        }
    }

}
