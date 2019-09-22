using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TownsInfo
    {
        public int Id { get; set; }
        public string TownCode { get; set; }
        public string TownName { get; set; }
        public string StaCode { get; set; }
    }
}
