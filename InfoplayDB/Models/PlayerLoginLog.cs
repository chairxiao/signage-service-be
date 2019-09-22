using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerLoginLog
    {
        public int Id { get; set; }
        public string Mac { get; set; }
        public DateTime? AddDate { get; set; }
    }
}
