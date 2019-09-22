using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ConfigStationInfo
    {
        public ConfigStationInfo()
        {
            ConfigStationFilter = new HashSet<ConfigStationFilter>();
        }

        public int Id { get; set; }
        public string ZoneCode { get; set; }
        public string ZoneName { get; set; }

        public virtual ICollection<ConfigStationFilter> ConfigStationFilter { get; set; }
    }
}
