using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PWeatherStation
    {
        public string StaCode { get; set; }
        public string StaName { get; set; }
        public string ParentStaCode { get; set; }
        public string Note { get; set; }
    }
}
