using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerLinkStts
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public DateTime? RecTime { get; set; }
        public int? OnlineSeconds { get; set; }
        public int? BytesReceived { get; set; }
        public int? BytesTransmitted { get; set; }
        public string Msg { get; set; }
    }
}
