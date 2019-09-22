using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramW
    {
        public string Wid { get; set; }
        public string Wname { get; set; }
        public int? W { get; set; }
        public int? H { get; set; }
        public int? OffsetX { get; set; }
        public int? OffsetY { get; set; }
        public string WindowPid { get; set; }
        public string WindowColor { get; set; }
        public bool? IsMain { get; set; }
    }
}
