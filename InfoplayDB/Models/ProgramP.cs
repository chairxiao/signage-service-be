using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramP
    {
        public ProgramP()
        {
            ProgramItem = new HashSet<ProgramItem>();
        }

        public string Pid { get; set; }
        public string Pname { get; set; }
        public string Info { get; set; }

        public virtual ICollection<ProgramItem> ProgramItem { get; set; }
    }
}
