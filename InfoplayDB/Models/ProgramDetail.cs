using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramDetail
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public int? FileId { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
