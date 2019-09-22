using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerPhone
    {
        public string MobilePhone { get; set; }
        public int? PlayerId { get; set; }
        public string SimcardSn { get; set; }
        public int? MonthlyDay { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BasicBalance { get; set; }
        public string PresentBalance { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string GprsSet { get; set; }
        public string SurplusFlow { get; set; }
        public string Status { get; set; }
        public string Provider { get; set; }
        public int Id { get; set; }

        public virtual Player Player { get; set; }
    }
}
