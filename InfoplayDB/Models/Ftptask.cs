using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Ftptask
    {
        public int Id { get; set; }
        public string TaskName { get; set; }
        public int? FtpserverId { get; set; }
        public string FtpTypeCode { get; set; }
        public int? Interval { get; set; }
        public DateTime? LastReceiveTime { get; set; }
        public string Note { get; set; }
        public bool? Flag { get; set; }
    }
}
