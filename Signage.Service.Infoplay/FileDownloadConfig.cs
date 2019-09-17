using System;

namespace Signage.Service.Infoplay
{
    public class FileDownloadConfig
    {
        FileDownloadItem[] DownloadItems { get; set; }
    }

    public class FileDownloadItem
    {
        public string FileName { get; set; }
        public string Uri { get; set; }
    }
}
