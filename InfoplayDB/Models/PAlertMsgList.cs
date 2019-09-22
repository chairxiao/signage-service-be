using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PAlertMsgList
    {
        public string StaSign { get; set; }
        public string MsgCode { get; set; }
        public string MsgColorCode { get; set; }
        public string StaCode { get; set; }
        public string Msg { get; set; }
        public DateTime? MsgDateTime { get; set; }
        public bool? AutoFlag { get; set; }
        public int Id { get; set; }
    }
}
