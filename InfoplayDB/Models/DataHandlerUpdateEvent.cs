using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class DataHandlerUpdateEvent
    {
        public int Id { get; set; }
        public int IsUpdated { get; set; }
        public string UriKey { get; set; }
        public DateTime RecTime { get; set; }
        public DateTime? ProcTime { get; set; }
        public string Status { get; set; }
    }
}
