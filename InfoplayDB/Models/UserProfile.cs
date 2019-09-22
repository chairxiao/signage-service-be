using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class UserProfile
    {
        public UserProfile()
        {
            UserIpLogin = new HashSet<UserIpLogin>();
            UserLog = new HashSet<UserLog>();
            UserProgramFilter = new HashSet<UserProgramFilter>();
            UserSet = new HashSet<UserSet>();
            VerifyManageSumitUserNavigation = new HashSet<VerifyManage>();
            VerifyManageVerifyUserNavigation = new HashSet<VerifyManage>();
        }

        public int UserId { get; set; }
        public string UserCode { get; set; }
        public string UserName { get; set; }
        public string Psw { get; set; }
        public string Phone { get; set; }
        public string Remark { get; set; }
        public int? ConutryCityId { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string DepartmentId { get; set; }
        public bool? ForceModifyPassword { get; set; }
        public bool? IsActive { get; set; }

        public virtual CountryCity ConutryCity { get; set; }
        public virtual ICollection<UserIpLogin> UserIpLogin { get; set; }
        public virtual ICollection<UserLog> UserLog { get; set; }
        public virtual ICollection<UserProgramFilter> UserProgramFilter { get; set; }
        public virtual ICollection<UserSet> UserSet { get; set; }
        public virtual ICollection<VerifyManage> VerifyManageSumitUserNavigation { get; set; }
        public virtual ICollection<VerifyManage> VerifyManageVerifyUserNavigation { get; set; }
    }
}
