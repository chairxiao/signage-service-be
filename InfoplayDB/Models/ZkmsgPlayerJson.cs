using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZkmsgPlayerJson
    {
        public int Id { get; set; }
        public int? Pid { get; set; }
        public bool? IsNew { get; set; }
        public string Json { get; set; }
        public DateTime? ExpireBeginTime { get; set; }
        public DateTime? ExpireEndTime { get; set; }
    }
}
