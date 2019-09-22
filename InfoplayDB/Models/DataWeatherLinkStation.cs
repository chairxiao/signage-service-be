using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class DataWeatherLinkStation
    {
        public string Id { get; set; }
        public string LinkId { get; set; }
        public string StaCode { get; set; }
        public int? Prior { get; set; }

        public virtual DataWeatherLink Link { get; set; }
    }
}
