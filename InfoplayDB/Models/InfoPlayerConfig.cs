using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class InfoPlayerConfig
    {
        public int PlayerId { get; set; }
        public string TransparencyKey { get; set; }
        public int? LocationType { get; set; }
        public string FollowParams { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
    }
}
