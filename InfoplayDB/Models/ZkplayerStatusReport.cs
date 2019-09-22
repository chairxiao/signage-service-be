using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZkplayerStatusReport
    {
        public int PlayerId { get; set; }
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public int? DeviceStatus { get; set; }
        public DateTime? ReportTime { get; set; }
        public bool? IsReported { get; set; }
        public byte[] TimespanZk { get; set; }
    }
}
