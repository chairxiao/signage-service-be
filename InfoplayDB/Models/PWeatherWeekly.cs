using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PWeatherWeekly
    {
        public int Id { get; set; }
        public int? PlayTime { get; set; }
        public int? PagePlayTime { get; set; }
        public string StaCode { get; set; }
        public string Title { get; set; }
        public string StationName { get; set; }
        public DateTime? ReleaseTime { get; set; }
        public string Page1 { get; set; }
        public string Page2 { get; set; }
        public string Page3 { get; set; }
        public string Page4 { get; set; }
        public string Page5 { get; set; }
        public bool? Flag { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string VerifyStatus { get; set; }

        public virtual Stationinfo StaCodeNavigation { get; set; }
    }
}
