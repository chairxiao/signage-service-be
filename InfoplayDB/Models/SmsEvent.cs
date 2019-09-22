using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SmsEvent
    {
        public SmsEvent()
        {
            SmsAlertEvent = new HashSet<SmsAlertEvent>();
            SmsLinkUser = new HashSet<SmsLinkUser>();
        }

        public int EventId { get; set; }
        public string EventName { get; set; }
        public string SmsContent { get; set; }
        public string Remark { get; set; }
        public int? AddBy { get; set; }
        public DateTime? AddDate { get; set; }
        public int? LastBy { get; set; }
        public DateTime? LastDate { get; set; }

        public virtual ICollection<SmsAlertEvent> SmsAlertEvent { get; set; }
        public virtual ICollection<SmsLinkUser> SmsLinkUser { get; set; }
    }
}
