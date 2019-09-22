using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Test1
    {
        public int Id { get; set; }
        public int? IdType { get; set; }
        public string Name { get; set; }
        public string StaName { get; set; }
        public string StaCode { get; set; }
        public byte[] VersionStamp { get; set; }
    }
}
