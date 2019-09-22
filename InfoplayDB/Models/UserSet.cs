using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class UserSet
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public bool? FrontPageDisplay { get; set; }
        public bool? FrontPageMap { get; set; }
        public bool? WatchAutoRefresh { get; set; }
        public int? WatchRefreshInterval { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
