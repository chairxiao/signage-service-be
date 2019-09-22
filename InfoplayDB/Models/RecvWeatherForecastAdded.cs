using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RecvWeatherForecastAdded
    {
        public string StaCode { get; set; }
        public DateTime DDate { get; set; }
        public string RecvContent { get; set; }
        public decimal? R { get; set; }
        public decimal? T { get; set; }
        public decimal? S { get; set; }
        public int? W { get; set; }
        public string FileName { get; set; }
        public DateTime? RecvDate { get; set; }
    }
}
