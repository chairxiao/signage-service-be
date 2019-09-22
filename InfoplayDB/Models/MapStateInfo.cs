using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class MapStateInfo
    {
        public int Id { get; set; }
        public int CountryCityId { get; set; }
        public string AddressName { get; set; }
        public string AddressPhoto { get; set; }
        public decimal? TrX { get; set; }
        public decimal? TrY { get; set; }
        public decimal? BlX { get; set; }
        public decimal? BlY { get; set; }
    }
}
