using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VideoProgramItem
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public string VideoName { get; set; }
        public int? InterVal { get; set; }
        public int? AddBy { get; set; }
        public DateTime? AddDate { get; set; }
        public string Path { get; set; }
        public bool? IsFlv { get; set; }
        public string VideoSize { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string FlvSize { get; set; }
        public string ChangeInfo { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
