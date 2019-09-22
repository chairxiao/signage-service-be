using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Zone
    {
        public Zone()
        {
            Stationinfo = new HashSet<Stationinfo>();
        }

        public string ZoneId { get; set; }
        public string ZoneName { get; set; }
        public string ParentZoneId { get; set; }
        public int? ZoneLevel { get; set; }

        public virtual ICollection<Stationinfo> Stationinfo { get; set; }
    }
}
