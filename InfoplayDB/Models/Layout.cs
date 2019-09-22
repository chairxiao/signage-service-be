using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Layout
    {
        public Layout()
        {
            Window = new HashSet<Window>();
        }

        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string Title { get; set; }
        public bool? Enable { get; set; }
        public int? PlayModel { get; set; }
        public int? SortId { get; set; }
        public float? PlaySencodes { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string BackgroundPicture { get; set; }
        public string BackgroundSound { get; set; }

        public virtual Player Player { get; set; }
        public virtual ICollection<Window> Window { get; set; }
    }
}
