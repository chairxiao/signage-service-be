using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VerifyManage
    {
        public VerifyManage()
        {
            VerifyProcess = new HashSet<VerifyProcess>();
        }

        public int Id { get; set; }
        public string VerifyContent { get; set; }
        public string VerifyStatusId { get; set; }
        public string VerifyTypeId { get; set; }
        public int? LinkId { get; set; }
        public int? SumitUser { get; set; }
        public DateTime? SumitDate { get; set; }
        public int? VerifyUser { get; set; }
        public DateTime? VerifyDate { get; set; }
        public string VerifyNote { get; set; }

        public virtual UserProfile SumitUserNavigation { get; set; }
        public virtual VerifyStatus VerifyStatus { get; set; }
        public virtual VerifyType VerifyType { get; set; }
        public virtual UserProfile VerifyUserNavigation { get; set; }
        public virtual ICollection<VerifyProcess> VerifyProcess { get; set; }
    }
}
