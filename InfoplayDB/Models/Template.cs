using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Template
    {
        public Template()
        {
            TemplateProgram = new HashSet<TemplateProgram>();
        }

        public string TemplateId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public string TemplateFileName { get; set; }

        public virtual TemplateParams TemplateParams { get; set; }
        public virtual ICollection<TemplateProgram> TemplateProgram { get; set; }
    }
}
