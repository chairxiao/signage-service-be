using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RecvWeatherForecastDetail
    {
        public int Id { get; set; }
        public int RecvWeatherForecastId { get; set; }
        public string StaCode { get; set; }
        public string ForeCastType { get; set; }
        public string Duration { get; set; }
        public string WeatherDesc { get; set; }
        public int MinT { get; set; }
        public int MaxT { get; set; }
        public int MinU { get; set; }
        public int MaxU { get; set; }
        public string Fs { get; set; }
        public string Fx { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual RecvWeatherForecast RecvWeatherForecast { get; set; }
    }
}
