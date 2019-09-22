using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramFileUri
    {
        public int Id { get; set; }
        public int ProgramFileId { get; set; }
        public string UpdateUri { get; set; }
        public int? IntervalSeconds { get; set; }

        public virtual ProgramFile ProgramFile { get; set; }
    }
}
