using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerStatusHistoryD
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public DateTime UDay { get; set; }
        public int Cs { get; set; }
        public int? Lxdays { get; set; }
        public DateTime? UpHistoryTime { get; set; }
    }
}
