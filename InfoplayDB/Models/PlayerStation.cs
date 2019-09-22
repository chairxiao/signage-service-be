using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerStation
    {
        public int Id { get; set; }
        public int? PlayId { get; set; }
        public string StaCode { get; set; }

        public virtual Player Play { get; set; }
    }
}
