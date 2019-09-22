using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerEvent
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string Event { get; set; }
        public DateTime? RaiseTime { get; set; }
        public DateTime? ProcessTime { get; set; }
        public int? ProcessFlag { get; set; }
    }
}
