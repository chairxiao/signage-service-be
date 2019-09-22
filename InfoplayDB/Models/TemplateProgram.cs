using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TemplateProgram
    {
        public int ProgramId { get; set; }
        public string TemplateId { get; set; }

        public virtual ProgramItem Program { get; set; }
        public virtual Template Template { get; set; }
    }
}
