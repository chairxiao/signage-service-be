using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class LedProgramItem
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public string PlayTitle { get; set; }
        public string PlayInfo { get; set; }
        public int? PlayEffect { get; set; }
        public int? FontSize { get; set; }
        public string Align { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string ConfigType { get; set; }
        public string ConfigData { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
