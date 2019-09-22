using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SmsAlertEvent
    {
        public int AlertEventId { get; set; }
        public int? EventId { get; set; }
        public string StaSign { get; set; }
        public string AlertCode { get; set; }
        public string AlertColorCode { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual SmsEvent Event { get; set; }
    }
}
