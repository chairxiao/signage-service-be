using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CountryCityPlayer
    {
        public int CountryCityId { get; set; }
        public int PlayerId { get; set; }

        public virtual CountryCity CountryCity { get; set; }
        public virtual Player Player { get; set; }
    }
}
