using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SmsLinkUser
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? EventId { get; set; }
        public int? Addby { get; set; }
        public DateTime? AddDate { get; set; }

        public virtual SmsEvent Event { get; set; }
        public virtual SmsUser User { get; set; }
    }
}
