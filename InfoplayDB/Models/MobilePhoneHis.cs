using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class MobilePhoneHis
    {
        public int Id { get; set; }
        public DateTime? LogDate { get; set; }
        public string MobileNo { get; set; }
        public int? MonthlyDay { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BasicBalance { get; set; }
        public decimal? PresentBalance { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string GprsSet { get; set; }
        public string SurplusFlow { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public int? CountryCityId { get; set; }
        public int? PlayerId { get; set; }
    }
}
