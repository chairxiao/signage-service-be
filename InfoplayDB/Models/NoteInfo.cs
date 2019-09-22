using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class NoteInfo
    {
        public int NoteIndoId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? PublishDate { get; set; }
        public int AddBy { get; set; }
        public DateTime? AddDate { get; set; }
        public int LastBy { get; set; }
        public DateTime? LastDate { get; set; }
        public bool Flag { get; set; }
    }
}
