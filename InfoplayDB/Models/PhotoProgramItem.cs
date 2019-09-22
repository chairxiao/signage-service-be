using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PhotoProgramItem
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public string PhotoName { get; set; }
        public int? PhotoNum { get; set; }
        public int? InterVal { get; set; }
        public string PlayType { get; set; }
        public int? AddBy { get; set; }
        public DateTime? AddDate { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
