using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerAutoStation
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string StaCode { get; set; }
        public int SeqNo { get; set; }

        public virtual Player Player { get; set; }
        public virtual Stationinfo StaCodeNavigation { get; set; }
    }
}
