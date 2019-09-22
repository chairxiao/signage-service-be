using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TaskClientState
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string ClientName { get; set; }
        public string ProcessServerName { get; set; }
        public int IsOnline { get; set; }
        public int IsChanged { get; set; }
        public DateTime LatestCheckTime { get; set; }
    }
}
