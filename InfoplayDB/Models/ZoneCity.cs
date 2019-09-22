using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZoneCity
    {
        public ZoneCity()
        {
            CountryCity = new HashSet<CountryCity>();
        }

        public int ZoneCityId { get; set; }
        public string CityName { get; set; }
        public string Stacode { get; set; }

        public virtual ICollection<CountryCity> CountryCity { get; set; }
    }
}
