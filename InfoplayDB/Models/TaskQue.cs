using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TaskQue
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string ClientName { get; set; }
        public int IsProcessing { get; set; }
        public int RetryCount { get; set; }
        public int MaxRetry { get; set; }
        public DateTime RecTime { get; set; }
        public DateTime ProcessTime { get; set; }
        public int ResponeCode { get; set; }
        public string ResponeMsg { get; set; }
        public int CodeType { get; set; }
        public string Type { get; set; }
        public string Params { get; set; }
    }
}
