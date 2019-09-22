using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZkreceivedMsg
    {
        public int Id { get; set; }
        public string SendSysId { get; set; }
        public string AcceptSysId { get; set; }
        public string InfoType { get; set; }
        public string Msg { get; set; }
        public DateTime? ReceiveTime { get; set; }
        public string HostUri { get; set; }
    }
}
