using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerUploadFile
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public string Type { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
    }
}
