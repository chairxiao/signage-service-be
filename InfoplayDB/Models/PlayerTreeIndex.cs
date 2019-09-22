using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerTreeIndex
    {
        public int SubId { get; set; }
        public int Parentid { get; set; }
        public int? TreeLevel { get; set; }
    }
}
