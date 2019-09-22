using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class IpLogin
    {
        public string Ip { get; set; }
        public int? CountryCityId { get; set; }
        public DateTime? AddDate { get; set; }
        public DateTime? LastDate { get; set; }

        public virtual CountryCity CountryCity { get; set; }
    }
}
