using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleCountryCityFilter = new HashSet<RoleCountryCityFilter>();
            RolePlayerFilter = new HashSet<RolePlayerFilter>();
            RoleProgramFilter = new HashSet<RoleProgramFilter>();
            RoleRightFilter = new HashSet<RoleRightFilter>();
        }

        public int RoleId { get; set; }
        public string RoleCode { get; set; }
        public string RoleName { get; set; }
        public string Remark { get; set; }
        public int? CountryCityId { get; set; }
        public int? RoleTypeId { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual CountryCity CountryCity { get; set; }
        public virtual RoleType RoleType { get; set; }
        public virtual ICollection<RoleCountryCityFilter> RoleCountryCityFilter { get; set; }
        public virtual ICollection<RolePlayerFilter> RolePlayerFilter { get; set; }
        public virtual ICollection<RoleProgramFilter> RoleProgramFilter { get; set; }
        public virtual ICollection<RoleRightFilter> RoleRightFilter { get; set; }
    }
}
