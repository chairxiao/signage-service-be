using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class StationFtp
    {
        public int Id { get; set; }
        public int? StationId { get; set; }
        public int? FtpserverId { get; set; }
        public byte? Type { get; set; }
        public string FileSuffix { get; set; }
        public DateTime? LastReceiveTime { get; set; }
        public string LastFileName { get; set; }
        public byte? Flag { get; set; }
    }
}
