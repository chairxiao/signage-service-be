using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RoleProgramFilter
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? ProgramId { get; set; }

        public virtual ProgramItem Program { get; set; }
        public virtual Role Role { get; set; }
    }
}
