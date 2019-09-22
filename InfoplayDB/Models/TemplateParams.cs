using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TemplateParams
    {
        public string TemplateId { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public bool? Used { get; set; }
        public string ParamType { get; set; }

        public virtual Template Template { get; set; }
    }
}
