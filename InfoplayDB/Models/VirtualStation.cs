using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VirtualStation
    {
        public string VirtualStaCode { get; set; }
        public string VirtualStaName { get; set; }
        public string StaSign { get; set; }
        public string StaCode { get; set; }
        public string DepartmentId { get; set; }
        public bool? IsUsing { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
