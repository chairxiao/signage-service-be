using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Stationinfo
    {
        public Stationinfo()
        {
            CountryCity = new HashSet<CountryCity>();
            PWeatherWeekly = new HashSet<PWeatherWeekly>();
            PlayerAutoStation = new HashSet<PlayerAutoStation>();
        }

        public string StaCode { get; set; }
        public string StaName { get; set; }
        public string StaType { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public double Altitude { get; set; }
        public int StaLevel { get; set; }
        public int CityLevel { get; set; }
        public string ZoneCity { get; set; }
        public string Area { get; set; }
        public string Region { get; set; }
        public int AgroSta { get; set; }
        public double AreaS { get; set; }
        public double AreaF { get; set; }
        public string Town { get; set; }
        public string DataSorceType { get; set; }
        public string ZoneId { get; set; }

        public virtual Zone Zone { get; set; }
        public virtual ICollection<CountryCity> CountryCity { get; set; }
        public virtual ICollection<PWeatherWeekly> PWeatherWeekly { get; set; }
        public virtual ICollection<PlayerAutoStation> PlayerAutoStation { get; set; }
    }
}
