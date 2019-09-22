using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class UserIpLogin
    {
        public int UserId { get; set; }
        public string Ip { get; set; }

        public virtual UserProfile User { get; set; }
    }
}
