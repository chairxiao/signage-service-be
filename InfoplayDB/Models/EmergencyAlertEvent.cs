using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class EmergencyAlertEvent
    {
        public int EventId { get; set; }
        public int? PlayerId { get; set; }
        public string StaSign { get; set; }
        public string AlertCode { get; set; }
        public string AlertColorCode { get; set; }

        public virtual Player Player { get; set; }
    }
}
