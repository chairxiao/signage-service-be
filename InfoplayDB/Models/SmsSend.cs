using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SmsSend
    {
        public int Id { get; set; }
        public string MobileNo { get; set; }
        public string SendContent { get; set; }
        public int? AddBy { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
