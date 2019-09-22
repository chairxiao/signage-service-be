using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramLedfile
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? FileSize { get; set; }
        public string CheckSum { get; set; }
        public DateTime? CheckTime { get; set; }
    }
}
