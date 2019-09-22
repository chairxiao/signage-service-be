using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RoleCountryCityFilter
    {
        public int RoleCityId { get; set; }
        public int? RoleId { get; set; }
        public int? CountryCityId { get; set; }

        public virtual CountryCity CountryCity { get; set; }
        public virtual Role Role { get; set; }
    }
}
