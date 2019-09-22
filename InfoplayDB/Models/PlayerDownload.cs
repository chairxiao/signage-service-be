using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerDownload
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int DownloadDetailId { get; set; }
        public string Uri { get; set; }
        public int? CheckCounter { get; set; }
        public int? DownloadCounter { get; set; }
        public int? ErrorCounter { get; set; }
        public int? TotalBytes { get; set; }
        public DateTime? ProcessTime { get; set; }
        public string CheckSum { get; set; }
        public int? DataSize { get; set; }
        public string Data { get; set; }
        public string Status { get; set; }
        public DateTime? DownloadTime { get; set; }
        public int? Version { get; set; }
        public int? DownloadedVersion { get; set; }
        public int? Retrys { get; set; }
        public string FileName { get; set; }
    }
}
