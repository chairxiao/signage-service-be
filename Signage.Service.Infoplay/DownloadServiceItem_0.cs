using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Signage.Service
{
    public class DownloadServiceItem_0
    {
        public readonly string uri;
        private int intervalSecs = 300;
        public int IntervalSecs
        {
            get
            {
                return intervalSecs;
            }
            set
            {
                if (value <= 0) return;
                if (value >= intervalSecs) return;
                intervalSecs = value;
            }
        }
        private List<string> SaveFileNames = new List<string>();
        public DownloadServiceItem_0(string uri)
        {
            this.uri = uri;
        }

        public void AddSaveFileName(string fullFileName)
        {
            var fn = Path.GetFullPath(fullFileName);
            if (!SaveFileNames.Contains(fn))
            {
                SaveFileNames.Add(fn);
            }
        }

        public void AddSaveFileName(string programRoot, string fileName)
        {
            var fullFileName = Path.Combine(programRoot, fileName).Trim();

            AddSaveFileName(fullFileName);
        }

        private DateTime lastUpdateTime = DateTime.Now.AddHours(-1);
        public void Update()
        {
            var ts = DateTime.Now - lastUpdateTime ;
            if (ts.TotalSeconds < intervalSecs) return;



        }

        
    }
}
