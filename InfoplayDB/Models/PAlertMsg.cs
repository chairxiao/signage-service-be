using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PAlertMsg
    {
        public int RecvAlertMsgId { get; set; }
        public string FileName { get; set; }
        public string StaSign { get; set; }
        public DateTime? RecvTime { get; set; }
        public string AlertMsgCode { get; set; }
        public DateTime? MsgHeaderTime { get; set; }
        public DateTime? AlertMsgTime { get; set; }
        public string AlertMsgText { get; set; }
    }
}
