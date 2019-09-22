using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class VerifyProcess
    {
        public int Id { get; set; }
        public int? ManageId { get; set; }
        public string VerifyStatus { get; set; }
        public string VerifyNote { get; set; }
        public int? AddBy { get; set; }
        public DateTime? AddDate { get; set; }

        public virtual VerifyManage Manage { get; set; }
    }
}
