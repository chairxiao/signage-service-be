using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CityForecastDetail
    {
        public int ForecastDetailId { get; set; }
        public int ForecastId { get; set; }
        public string StaCode { get; set; }
        public string ForeCastType { get; set; }
        public string WeatherDesc { get; set; }
        public string Fs { get; set; }
        public string Fx { get; set; }
        public decimal MinT { get; set; }
        public decimal MaxT { get; set; }

        public virtual CityForecast Forecast { get; set; }
    }
}
