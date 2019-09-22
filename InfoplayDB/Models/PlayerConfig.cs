using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerConfig
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string Mac { get; set; }
        public string Sn { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public string Address { get; set; }
        public string TermSn { get; set; }
        public string DisplaySn { get; set; }
        public string SimcardSn { get; set; }
        public string MobilePhone { get; set; }
        public string PlayerName { get; set; }
        public string EquipmentModel { get; set; }
        public string BoardType { get; set; }
        public string MobileTemplateModel { get; set; }
        public string CardModel { get; set; }

        public virtual Player Player { get; set; }
    }
}
