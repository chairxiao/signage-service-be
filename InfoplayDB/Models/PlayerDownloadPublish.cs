using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerDownloadPublish
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int DownloadDetailId { get; set; }
        public string Process { get; set; }
        public DateTime? RecTime { get; set; }
        public int? ProcState { get; set; }
        public DateTime? ProcTime { get; set; }
    }
}
