using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VoiceProgramItem
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public int? PlayCount { get; set; }
        public DateTime? AddDate { get; set; }
        public string Path { get; set; }
        public string VoiceSize { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? InterVal { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
