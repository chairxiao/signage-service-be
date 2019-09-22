using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class DataHandlerUpdater
    {
        public int Id { get; set; }
        public int ProcState { get; set; }
        public int? Retrys { get; set; }
        public string UriKey { get; set; }
        public string PlayerIds { get; set; }
        public string Data { get; set; }
        public DateTime? RecTime { get; set; }
        public DateTime? ProcTime { get; set; }
        public string Status { get; set; }
    }
}
