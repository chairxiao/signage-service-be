using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RolePlayerFilter
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public int PlayerId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Role Role { get; set; }
    }
}
