using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ControlRights
    {
        public ControlRights()
        {
            RoleRightFilter = new HashSet<RoleRightFilter>();
        }

        public int RightId { get; set; }
        public string RightCode { get; set; }
        public string RightName { get; set; }
        public string RightDesc { get; set; }
        public string ParentFolder { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string Url { get; set; }
        public string ModelId { get; set; }

        public virtual ICollection<RoleRightFilter> RoleRightFilter { get; set; }
    }
}
