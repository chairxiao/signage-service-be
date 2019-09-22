using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerLog
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public DateTime? LogTime { get; set; }
        public string LogLevel { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public int? Source { get; set; }
        public int? LevelValue { get; set; }

        public virtual Player Player { get; set; }
    }
}
