using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerServerBack
    {
        public int PlayerId { get; set; }
        public string InterfaceId { get; set; }
        public int? Prior { get; set; }
        public DateTime? CheckTime { get; set; }
        public bool? IsUpdated { get; set; }
        public DateTime? DownloadTime { get; set; }
    }
}
