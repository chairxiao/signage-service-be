using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class UserProgramFilter
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ProgramId { get; set; }

        public virtual ProgramItem Program { get; set; }
        public virtual UserProfile User { get; set; }
    }
}
