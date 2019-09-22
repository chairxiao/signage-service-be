using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramItemSuperComm
    {
        public int ProgramItemId { get; set; }
        public string FileType { get; set; }
        public string Drv { get; set; }
        public string Path { get; set; }
        public string FileName { get; set; }
        public int? Entermode { get; set; }
        public int? Step { get; set; }

        public virtual ProgramItem ProgramItem { get; set; }
    }
}
