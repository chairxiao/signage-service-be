using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class FtpFileMonitor
    {
        public int Id { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public DateTime? FileModifyTime { get; set; }
        public bool? IsUpdate { get; set; }
    }
}
