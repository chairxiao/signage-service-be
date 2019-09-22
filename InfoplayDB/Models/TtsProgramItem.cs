using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TtsProgramItem
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public string PlayInfo { get; set; }
        public int? PlayCount { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? InterVal { get; set; }
        public bool? IsBg { get; set; }
        public string Mp3bg { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
