using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RoleType
    {
        public RoleType()
        {
            Role = new HashSet<Role>();
        }

        public int Id { get; set; }
        public string RoleTypeName { get; set; }

        public virtual ICollection<Role> Role { get; set; }
    }
}
