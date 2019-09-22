using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZkalertMsg
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string AlertId { get; set; }
        public DateTime? SendTime { get; set; }
        public string AlertSource { get; set; }
        public string AlertArea { get; set; }
        public string AlertStatus { get; set; }
        public string AlertType { get; set; }
        public string AlertLevel { get; set; }
        public string AlertMode { get; set; }
        public string AlertUrgent { get; set; }
        public string ExpireTime { get; set; }
        public string AlertTitle { get; set; }
        public string AlertLedcontent { get; set; }
        public string AlertDlbcontent { get; set; }
        public string AlertFile { get; set; }
        public DateTime? ExpireBeginTime { get; set; }
        public DateTime? ExpireEndTime { get; set; }
        public string XyPoint { get; set; }
        public string XyArea { get; set; }
        public int? Priority { get; set; }
        public int? DisplayMode { get; set; }
        public int? DisplayTime { get; set; }
        public int? ActiveStatus { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public string ZkalertCode { get; set; }
        public string OldAlertId { get; set; }
        public bool? IsOld { get; set; }
        public bool? IsZkApi { get; set; }
        public DateTime? ZkApiTime { get; set; }
    }
}
