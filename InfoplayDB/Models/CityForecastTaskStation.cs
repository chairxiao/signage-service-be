using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CityForecastTaskStation
    {
        public string StaCode { get; set; }
        public bool? TranWeather { get; set; }
        public bool? TranWeatherMuiti { get; set; }
    }
}
