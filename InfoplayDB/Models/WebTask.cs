using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class WebTask
    {
        public int WebTaskId { get; set; }
        public string Name { get; set; }
        public string Uri { get; set; }
        public string TaskType { get; set; }
        public DateTime? LastDownloadTime { get; set; }
        public int? Interval { get; set; }
        public bool? Flag { get; set; }
        public string UserName { get; set; }
        public string Psw { get; set; }
    }
}
