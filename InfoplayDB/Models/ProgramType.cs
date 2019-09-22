using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramType
    {
        public ProgramType()
        {
            ProgramItem = new HashSet<ProgramItem>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ProgramItem> ProgramItem { get; set; }
    }
}
