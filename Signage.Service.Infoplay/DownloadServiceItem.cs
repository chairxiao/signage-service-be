using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Signage.Service
{
    public class DownloadServiceItem
    {
        public readonly string uri;
        private List<string> SaveFileNames = new List<string>();
        public DownloadServiceItem(string uri)
        {
            this.uri = uri;
        }

        public void AddSaveFileName(string fullFileName)
        {
            if (!SaveFileNames.Contains(fullFileName))
            {
                SaveFileNames.Add(fullFileName);
            }
        }

        public void AddSaveFileName(string programRoot, string fileName)
        {
            var fn = Path.Combine(programRoot, fileName).Trim();
            var fullFileName = Path.GetFullPath(fn);
            AddSaveFileName(fullFileName);
        }
    }
}
