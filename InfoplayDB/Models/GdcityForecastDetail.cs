using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class GdcityForecastDetail
    {
        public int ForecastDetailId { get; set; }
        public int ForecastId { get; set; }
        public string City { get; set; }
        public string ForeCastType { get; set; }
        public string WeatherDesc { get; set; }
        public int MinT { get; set; }
        public int MaxT { get; set; }

        public virtual GdcityForecast Forecast { get; set; }
    }
}
