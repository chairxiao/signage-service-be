using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TestTable1
    {
        public int Id { get; set; }
        public string CustomName { get; set; }
        public int? Value1 { get; set; }
        public int? Value2 { get; set; }
    }
}
