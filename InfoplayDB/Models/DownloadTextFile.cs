using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class DownloadTextFile
    {
        public string DownloadType { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime? DownloadTime { get; set; }
        public string Content { get; set; }
        public bool? IsNew { get; set; }
    }
}
