using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Menu
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public int? SequenceIndex { get; set; }
        public string NameText { get; set; }
        public string Title { get; set; }
        public string Href { get; set; }
        public string EntityId { get; set; }
        public int? Type { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public string Icon { get; set; }
        public string IconHover { get; set; }
        public int? Group { get; set; }
        public string RightCode { get; set; }
    }
}
