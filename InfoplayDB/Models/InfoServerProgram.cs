using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class InfoServerProgram
    {
        public int Id { get; set; }
        public string ServerId { get; set; }
        public int? ProgramId { get; set; }
        public string CheckSum { get; set; }
        public DateTime? CheckTime { get; set; }
        public bool? IsUpdated { get; set; }
        public DateTime? DownloadTime { get; set; }
        public int? Retrys { get; set; }
        public int? Flag { get; set; }
        public string Msg { get; set; }
    }
}
