using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Download
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string RequestUri { get; set; }
        public int? IntervalSeconds { get; set; }
        public int? DownloadType { get; set; }
        public string Note { get; set; }
    }
}
