using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class WeatherStation
    {
        public int Id { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public string StaCode { get; set; }
        public string StaName { get; set; }
    }
}
