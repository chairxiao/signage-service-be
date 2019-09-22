using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class GdcityForecast
    {
        public GdcityForecast()
        {
            GdcityForecastDetail = new HashSet<GdcityForecastDetail>();
        }

        public int ForecastId { get; set; }
        public DateTime ForeCastTime { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public string ForeCastMan { get; set; }
        public string FileName { get; set; }
        public DateTime ReceiveTime { get; set; }
        public string ForeCastText { get; set; }

        public virtual ICollection<GdcityForecastDetail> GdcityForecastDetail { get; set; }
    }
}
