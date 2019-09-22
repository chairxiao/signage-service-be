using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CityForecast
    {
        public CityForecast()
        {
            CityForecastDetail = new HashSet<CityForecastDetail>();
        }

        public int ForecastId { get; set; }
        public DateTime ForeCastTime { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ForeCastRegion { get; set; }
        public string FileName { get; set; }
        public DateTime ReceiveTime { get; set; }

        public virtual ICollection<CityForecastDetail> CityForecastDetail { get; set; }
    }
}
