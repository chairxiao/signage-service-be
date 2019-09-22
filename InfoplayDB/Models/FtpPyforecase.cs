using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class FtpPyforecase
    {
        public int Id { get; set; }
        public string ForecastType { get; set; }
        public DateTime? ForecastCurDate { get; set; }
        public DateTime? ForecastDate { get; set; }
        public string Week { get; set; }
        public string Icon { get; set; }
        public string Temp { get; set; }
        public string Desc { get; set; }
    }
}
