using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ConfigStationFilter
    {
        public int Id { get; set; }
        public string ZoneCode { get; set; }
        public string StaCode { get; set; }
        public string FilterType { get; set; }

        public virtual ConfigStationInfo ZoneCodeNavigation { get; set; }
    }
}
