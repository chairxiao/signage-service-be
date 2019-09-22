using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ClientConfig
    {
        public string Mac { get; set; }
        public DateTime? PowerOnTime { get; set; }
        public DateTime? PowerOffTime { get; set; }
        public DateTime? ScreenOnTime { get; set; }
        public DateTime? ScreenOffTime { get; set; }
        public DateTime? PlayStartTime { get; set; }
        public DateTime? PlayStopTime { get; set; }
        public string Sn { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Address { get; set; }
    }
}
