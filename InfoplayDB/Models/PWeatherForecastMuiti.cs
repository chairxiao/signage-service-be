using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PWeatherForecastMuiti
    {
        public int Id { get; set; }
        public string StaCode { get; set; }
        public DateTime ForeCastTime { get; set; }
        public string EffectiveTime { get; set; }
        public double MinT24 { get; set; }
        public double MaxT24 { get; set; }
        public string WeatherDesc24 { get; set; }
        public string FlashCode24 { get; set; }
        public double MinT48 { get; set; }
        public double MaxT48 { get; set; }
        public string WeatherDesc48 { get; set; }
        public string FlashCode48 { get; set; }
        public double MinT72 { get; set; }
        public double MaxT72 { get; set; }
        public string WeatherDesc72 { get; set; }
        public string FlashCode72 { get; set; }
        public string Fgtext { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? ForeCastBeginTime { get; set; }
        public DateTime? ForeCastEndTime { get; set; }
        public string DataSource { get; set; }
        public DateTime? EffectiveBeginTime { get; set; }
        public DateTime? EffectiveEndTime { get; set; }
        public byte[] TimeStampV { get; set; }
    }
}
