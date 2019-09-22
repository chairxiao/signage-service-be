using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TTcObs
    {
        public int Obsid { get; set; }
        public int? Tsid { get; set; }
        public string Fcid { get; set; }
        public DateTime? Ddatetime { get; set; }
        public string Tcid { get; set; }
        public string Tcrank { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Windspeed { get; set; }
        public double? Gust { get; set; }
        public double? Pressure { get; set; }
        public string Direction { get; set; }
        public double? Speed { get; set; }
        public double? Rr06 { get; set; }
        public double? Rr07 { get; set; }
        public double? Rr08 { get; set; }
        public double? Rr10 { get; set; }
        public double? Rr12 { get; set; }
    }
}
