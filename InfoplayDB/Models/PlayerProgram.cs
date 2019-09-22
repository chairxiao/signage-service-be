using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerProgram
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public int? ProgramId { get; set; }
        public string CheckSum { get; set; }
        public DateTime? CheckTime { get; set; }
        public bool? IsUpdated { get; set; }
        public DateTime? DownloadTime { get; set; }
        public int? Retrys { get; set; }
        public int? Flag { get; set; }
        public string Msg { get; set; }
        public int? Status { get; set; }
        public int? UpdateWay { get; set; }
        public string IndexPageMd5 { get; set; }
        public string IndexPage { get; set; }
        public string ConfigMd5 { get; set; }
        public string ConfigPath { get; set; }
        public bool? IsIndexPageChanged { get; set; }
        public bool? IsConfigChanged { get; set; }

        public virtual Player Player { get; set; }
        public virtual ProgramItem Program { get; set; }
    }
}
