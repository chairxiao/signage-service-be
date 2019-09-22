using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VerifyStatus
    {
        public VerifyStatus()
        {
            VerifyManage = new HashSet<VerifyManage>();
        }

        public string StatusId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<VerifyManage> VerifyManage { get; set; }
    }
}
