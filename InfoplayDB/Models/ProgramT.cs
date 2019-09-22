using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramT
    {
        public ProgramT()
        {
            ProgramItem = new HashSet<ProgramItem>();
        }

        public string Tid { get; set; }
        public string Tname { get; set; }

        public virtual ICollection<ProgramItem> ProgramItem { get; set; }
    }
}
