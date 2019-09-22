using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RoleRightFilter
    {
        public int RoleRightId { get; set; }
        public int RoleId { get; set; }
        public int ControlRightsId { get; set; }
        public short RightAdd { get; set; }
        public short RightModify { get; set; }
        public short RightDelete { get; set; }
        public short RightRead { get; set; }
        public short RightPrint { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ControlRights ControlRights { get; set; }
        public virtual Role Role { get; set; }
    }
}
