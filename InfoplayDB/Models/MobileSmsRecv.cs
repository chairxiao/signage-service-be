using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class MobileSmsRecv
    {
        public int Id { get; set; }
        public string SimCardSn { get; set; }
        public string SmsContent { get; set; }
        public DateTime? RecvTime { get; set; }
        public string Sender { get; set; }
        public int? PlayerId { get; set; }
        public int? ProcessStatus { get; set; }
        public string ProcessMsg { get; set; }
    }
}
