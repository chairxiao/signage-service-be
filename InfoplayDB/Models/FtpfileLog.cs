using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class FtpfileLog
    {
        public int Id { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
