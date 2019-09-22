using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayTimeTablebak
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public DateTime? StartPlayTime { get; set; }
        public DateTime? StopPlayTime { get; set; }
        public bool? Enable { get; set; }
        public bool? Sun { get; set; }
        public bool? Mon { get; set; }
        public bool? Tue { get; set; }
        public bool? Wed { get; set; }
        public bool? Thu { get; set; }
        public bool? Fri { get; set; }
        public bool? Sat { get; set; }
    }
}
