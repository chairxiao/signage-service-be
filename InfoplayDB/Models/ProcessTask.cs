using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProcessTask
    {
        public int ProcessId { get; set; }
        public string ProcessType { get; set; }
        public string Note { get; set; }
        public int? ProgramCount { get; set; }
        public int? ProgramSuccessCount { get; set; }
        public int? ProgramFailCount { get; set; }
        public int? PlayerCount { get; set; }
        public int? PlayerSuccessCount { get; set; }
        public int? PlayerFailCount { get; set; }
        public int? ProcessUser { get; set; }
        public DateTime? ProcessTime { get; set; }
        public DateTime? ProcessFinishTime { get; set; }
        public int? ProcessState { get; set; }
    }
}
