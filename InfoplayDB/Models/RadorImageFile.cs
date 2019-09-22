using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RadorImageFile
    {
        public int Id { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        public DateTime? FileCreateTime { get; set; }
        public byte[] Data { get; set; }
        public DateTime? AddTime { get; set; }
    }
}
