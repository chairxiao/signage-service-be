using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerPublish
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string ProgramIds { get; set; }
        public int ProcState { get; set; }
        public bool IsSyncAllProgram { get; set; }
        public DateTime RecTime { get; set; }
        public DateTime? ProcTime { get; set; }
        public string Msg { get; set; }
        public int? ProcesserId { get; set; }
        public int? Retrys { get; set; }
    }
}
