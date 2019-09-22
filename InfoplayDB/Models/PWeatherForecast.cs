using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PWeatherForecast
    {
        public int Id { get; set; }
        public string StaCode { get; set; }
        public string WeatherDesc { get; set; }
        public string EffectiveTime { get; set; }
        public double MinT { get; set; }
        public double MaxT { get; set; }
        public double MinU { get; set; }
        public double MaxU { get; set; }
        public string Fs { get; set; }
        public string Fx { get; set; }
        public string CoastalWind { get; set; }
        public string CoastalTyphoon { get; set; }
        public string Fcode { get; set; }
        public string Fgcode2 { get; set; }
        public string Fgtext { get; set; }
        public DateTime? ForeCastTime { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? ForeCastBeginTime { get; set; }
        public DateTime? ForeCastEndTime { get; set; }
        public string DataSource { get; set; }
        public DateTime? EffectiveBeginTime { get; set; }
        public DateTime? EffectiveEndTime { get; set; }
        public byte[] TimeStampV { get; set; }
    }
}
