using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZktestMsg
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public DateTime? SendTime { get; set; }
        public string AlertId { get; set; }
        public string AlertType { get; set; }
        public string AlertLevel { get; set; }
        public string AlertMode { get; set; }
        public string UrgentLevel { get; set; }
        public string ExpireTime { get; set; }
        public DateTime? ExpireBeginTime { get; set; }
        public DateTime? ExpireEndTime { get; set; }
        public string InfoTitle { get; set; }
        public string InfoContent { get; set; }
        public string AffixPath { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public int? Priority { get; set; }
        public int? DisplayMode { get; set; }
        public int? DisplayTime { get; set; }
        public string AlertArea { get; set; }
        public string AlertFile { get; set; }
        public string Description { get; set; }
        public string DeviceId { get; set; }
    }
}
