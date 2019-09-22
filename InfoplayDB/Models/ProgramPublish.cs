using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramPublish
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public DateTime RecTime { get; set; }
        public int ProcState { get; set; }
        public DateTime? ProcTime { get; set; }
        public string Msg { get; set; }
        public int? ProcessId { get; set; }
        public int? Retrys { get; set; }
    }
}
