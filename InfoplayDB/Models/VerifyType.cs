using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VerifyType
    {
        public VerifyType()
        {
            VerifyManage = new HashSet<VerifyManage>();
        }

        public string Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<VerifyManage> VerifyManage { get; set; }
    }
}
