using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class LogLevel
    {
        public int Id { get; set; }
        public string LevelName { get; set; }
        public string DisplayName { get; set; }
    }
}
