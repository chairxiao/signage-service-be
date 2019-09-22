using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RecvWeatherForecast
    {
        public RecvWeatherForecast()
        {
            RecvWeatherForecastDetail = new HashSet<RecvWeatherForecastDetail>();
        }

        public int RecvWeatherForecastId { get; set; }
        public string StaCode { get; set; }
        public DateTime? RecvTime { get; set; }
        public string FileName { get; set; }
        public DateTime? ForeCastTime { get; set; }
        public string ForeCastMsg { get; set; }
        public bool TranFlag { get; set; }

        public virtual ICollection<RecvWeatherForecastDetail> RecvWeatherForecastDetail { get; set; }
    }
}
