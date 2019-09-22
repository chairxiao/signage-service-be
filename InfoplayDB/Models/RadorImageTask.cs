using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RadorImageTask
    {
        public string FileType { get; set; }
        public int? Photonum { get; set; }
        public int? ProgramId { get; set; }
        public string PlaySeqName { get; set; }
        public string PlaySeq { get; set; }
        public string SaveFilename { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
