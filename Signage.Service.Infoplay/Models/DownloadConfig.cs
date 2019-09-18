using System;

namespace Signage.Service {
    public class DownloadConfig
    {
        public DownloadConfigItem[] DownloadItems { get; set; }
    }

    public class DownloadConfigItem
    {
        public string FileName { get; set; }
        public string Uri { get; set; }
    }
}
