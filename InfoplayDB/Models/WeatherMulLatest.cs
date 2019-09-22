using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class WeatherMulLatest
    {
        public string StaCode { get; set; }
        public DateTime DDate { get; set; }
        public string F2x { get; set; }
        public decimal? F2s { get; set; }
        public string F10x { get; set; }
        public decimal? F10s { get; set; }
        public string Fzx { get; set; }
        public decimal? Fzs { get; set; }
        public string Fztime { get; set; }
        public string Fjx { get; set; }
        public decimal? Fjs { get; set; }
        public string Fjtime { get; set; }
        public decimal? R { get; set; }
        public decimal? T { get; set; }
        public decimal? TMax { get; set; }
        public string TMaxTime { get; set; }
        public decimal? TMin { get; set; }
        public string TMinTime { get; set; }
        public int? U { get; set; }
        public int? UMax { get; set; }
        public string UMaxTime { get; set; }
        public int? UMin { get; set; }
        public string UMinTime { get; set; }
        public decimal? Td { get; set; }
        public decimal? P { get; set; }
        public decimal? PMax { get; set; }
        public string PMaxTime { get; set; }
        public decimal? PMin { get; set; }
        public string PMinTime { get; set; }
    }
}
