using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Tvconfig
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string ClosePower { get; set; }
        public string OpenPower { get; set; }
        public string Remark { get; set; }
    }
}
