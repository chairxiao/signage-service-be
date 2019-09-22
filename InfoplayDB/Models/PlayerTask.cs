using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerTask
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string TaskType { get; set; }
        public int? PlayerId { get; set; }
        public DateTime? ReqTime { get; set; }
        public DateTime? AnswerTime { get; set; }
        public int? Counter { get; set; }
        public string Status { get; set; }
        public string Transfer { get; set; }
        public string Param { get; set; }
    }
}
