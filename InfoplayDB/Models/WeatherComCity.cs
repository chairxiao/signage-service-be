using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class WeatherComCity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PrarentId { get; set; }
        public string Flag { get; set; }
        public string StaCode { get; set; }
    }
}
