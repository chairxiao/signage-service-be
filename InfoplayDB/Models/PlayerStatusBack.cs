using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerStatusBack
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }
        public string LoginServer { get; set; }
    }
}
