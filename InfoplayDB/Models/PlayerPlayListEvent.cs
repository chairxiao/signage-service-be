using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerPlayListEvent
    {
        public int PlayerId { get; set; }
        public short? IsUpdated { get; set; }
        public string Version { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
