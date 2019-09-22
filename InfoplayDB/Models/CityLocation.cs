using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CityLocation
    {
        public int Id { get; set; }
        public int? CityId { get; set; }
        public decimal? CityX { get; set; }
        public decimal? CityY { get; set; }
    }
}
