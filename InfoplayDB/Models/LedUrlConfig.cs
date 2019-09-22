using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class LedUrlConfig
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string DataUrl { get; set; }
    }
}
