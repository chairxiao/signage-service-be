using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VersionInfo
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Version { get; set; }
        public string Note { get; set; }
        public DateTime? AddDate { get; set; }
        public bool? Flag { get; set; }
    }
}
