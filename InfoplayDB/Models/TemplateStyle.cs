using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TemplateStyle
    {
        public int Id { get; set; }
        public string TemplateName { get; set; }
        public string Title { get; set; }
        public string TemplateContent { get; set; }
        public string Image { get; set; }
        public int? PlaySeconds { get; set; }
        public string T { get; set; }
        public string W { get; set; }
        public string P { get; set; }
        public int? DownloadId { get; set; }
    }
}
