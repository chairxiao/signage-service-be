using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerFile
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public int? FileId { get; set; }
        public string CheckSum { get; set; }
        public DateTime? CheckTime { get; set; }
        public bool? IsUpdate { get; set; }
        public DateTime? DownloadTime { get; set; }
        public string Status { get; set; }
        public DateTime? DownloadTimeSpan { get; set; }
        public int? Retrys { get; set; }
        public int? Flag { get; set; }

        public virtual Player Player { get; set; }
    }
}
