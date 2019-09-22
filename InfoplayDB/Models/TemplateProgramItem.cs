using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TemplateProgramItem
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public string Title { get; set; }
        public int? TemplateId { get; set; }
        public DateTime? AddDate { get; set; }
        public int? DownloadId { get; set; }
        public string StaCode { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
