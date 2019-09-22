using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramFile
    {
        public ProgramFile()
        {
            ProgramFileUri = new HashSet<ProgramFileUri>();
        }

        public int Id { get; set; }
        public string FileName { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? FileSize { get; set; }
        public string CheckSum { get; set; }
        public DateTime? CheckTime { get; set; }

        public virtual ICollection<ProgramFileUri> ProgramFileUri { get; set; }
    }
}
