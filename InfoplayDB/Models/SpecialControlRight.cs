using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SpecialControlRight
    {
        public int Id { get; set; }
        public int ControlRightId { get; set; }
        public string RightCode { get; set; }
        public string RightName { get; set; }
        public string RightDesc { get; set; }
        public int CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
