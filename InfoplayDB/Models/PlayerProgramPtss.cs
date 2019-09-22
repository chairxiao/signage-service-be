using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerProgramPtss
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int ProgramId { get; set; }
        public int PtSs { get; set; }
        public int IsUpdated { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DownloadTime { get; set; }
        public string Status { get; set; }
    }
}
