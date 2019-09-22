using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerVersion
    {
        public int PlayerId { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Version { get; set; }
        public string CheckSum { get; set; }
        public string FileName { get; set; }
    }
}
