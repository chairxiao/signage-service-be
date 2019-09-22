using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class DownLoadDetail
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public int? DownloadId { get; set; }
        public string ReplaceKey { get; set; }
        public string DownloadPath { get; set; }
        public int? IntervalSeconds { get; set; }
        public bool? RequirePlayerId { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
