using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CodeMaster
    {
        public string CodeKey { get; set; }
        public string Value { get; set; }
        public decimal SeqNo { get; set; }
        public string Remark { get; set; }
        public string Remark2 { get; set; }
        public bool? Flag { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
