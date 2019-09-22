using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerLedruntimeInfo
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string SoftwareVersion { get; set; }
        public string HardwareVersion { get; set; }
        public short? SdOk { get; set; }
        public short? PowerMode { get; set; }
        public short? TotalProgCount { get; set; }
        public string CurrentProgram { get; set; }
        public short? Temperature { get; set; }
        public short? R { get; set; }
        public short? Brightness { get; set; }
        public string Font { get; set; }
        public DateTime? Ledtime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual Player Player { get; set; }
    }
}
