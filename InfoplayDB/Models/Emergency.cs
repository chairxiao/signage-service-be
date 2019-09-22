using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Emergency
    {
        public int EmergencyId { get; set; }
        public int? PlayerId { get; set; }
        public DateTime? PlayBeginTime { get; set; }
        public DateTime? PlayEndTime { get; set; }
        public int? LayoutId { get; set; }
        public int? PlayLevel { get; set; }
        public string OptionFlag { get; set; }
        public string PlayType { get; set; }
        public DateTime? AddTime { get; set; }
        public DateTime? LastTime { get; set; }

        public virtual Player Player { get; set; }
    }
}
