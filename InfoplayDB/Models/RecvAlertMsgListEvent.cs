using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RecvAlertMsgListEvent
    {
        public string StaCode { get; set; }
        public string StaSign { get; set; }
        public string Msg { get; set; }
        public string MsgCode { get; set; }
        public string MsgColorCode { get; set; }
        public string MsgTime { get; set; }
        public int? AutoFlag { get; set; }
        public DateTime? MsgDateTime { get; set; }
        public int Id { get; set; }
    }
}
