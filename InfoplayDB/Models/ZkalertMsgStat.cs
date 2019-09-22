using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZkalertMsgStat
    {
        public string AlertInfoId { get; set; }
        public string AlertArea { get; set; }
        public string VendorSysId { get; set; }
        public string AlertMode { get; set; }
        public int? TotalNum { get; set; }
        public int? SuccessNum { get; set; }
        public int? FailureNum { get; set; }
        public bool? IsLastData { get; set; }
        public bool? IsReported { get; set; }
        public byte[] TimespanZk { get; set; }
    }
}
