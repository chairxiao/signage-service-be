using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SmsEventRaise
    {
        public int Id { get; set; }
        public int? EventId { get; set; }
        public string EventName { get; set; }
        public string UserName { get; set; }
        public string MobileNo { get; set; }
        public string SendContent { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
