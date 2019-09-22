using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramDataTask
    {
        public int TaskId { get; set; }
        public string TaskType { get; set; }
        public string Uri { get; set; }
        public string SavePath { get; set; }
        public string FileName { get; set; }
        public DateTime? LastDownloadTime { get; set; }
        public int? Interval { get; set; }
        public bool? Flag { get; set; }
    }
}
