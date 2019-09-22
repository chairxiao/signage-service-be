using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class DownloadTextFileTask
    {
        public string DownloadType { get; set; }
        public string FileName { get; set; }
        public int ProgramId { get; set; }
        public string SaveFileName { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int Id { get; set; }
    }
}
