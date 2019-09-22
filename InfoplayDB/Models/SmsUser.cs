using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SmsUser
    {
        public SmsUser()
        {
            SmsLinkUser = new HashSet<SmsLinkUser>();
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string MobilePhone { get; set; }
        public int? CountryId { get; set; }
        public string Remark { get; set; }
        public int? Addby { get; set; }
        public DateTime? AddDate { get; set; }
        public int? LastBy { get; set; }
        public DateTime? LastDate { get; set; }

        public virtual CountryCity Country { get; set; }
        public virtual ICollection<SmsLinkUser> SmsLinkUser { get; set; }
    }
}
