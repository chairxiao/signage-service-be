using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class LogSource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public int? LogLevelId { get; set; }
    }
}
