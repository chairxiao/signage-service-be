using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Signage.Service.Infoplay
{
    public class DownloadSaveFile
    {
        public string ProgramRoot { get; set; }
        public string FileName { get; set; }
        public string SaveType { get; set; }

    }

    public static class DownloadSaveItemExtensions {
        public static string GetFullFileName(this DownloadSaveFile saveItem)
        {
            var fn = Path.Combine(saveItem.ProgramRoot, saveItem.FileName);
            return Path.GetFullPath(fn);
        }


    }
}
