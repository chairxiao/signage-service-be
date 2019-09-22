using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayListShare
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool? Enable { get; set; }
        public int? ManagerId { get; set; }
        public int? ProgramId { get; set; }
        public int? SortId { get; set; }
        public bool? Lock { get; set; }
        public int? PlaySeconds { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual PlayListShareManager Manager { get; set; }
    }
}
