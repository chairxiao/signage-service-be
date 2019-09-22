using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class UserLog
    {
        public int LogId { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? LoginTime { get; set; }
        public DateTime? LogoutTime { get; set; }
        public string Ip { get; set; }
        public string Mac { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
