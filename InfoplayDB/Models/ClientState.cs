using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ClientState
    {
        public int Id { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
