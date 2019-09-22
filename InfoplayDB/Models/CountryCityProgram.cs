using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CountryCityProgram
    {
        public int CountryCityId { get; set; }
        public int ProgramId { get; set; }

        public virtual CountryCity CountryCity { get; set; }
        public virtual ProgramItem Program { get; set; }
    }
}
