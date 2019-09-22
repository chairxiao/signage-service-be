using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Window
    {
        public Window()
        {
            PlayList = new HashSet<PlayList>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? LayoutId { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Width { get; set; }
        public int? Height { get; set; }
        public bool? IsMain { get; set; }
        public int? Z { get; set; }

        public virtual Layout Layout { get; set; }
        public virtual ICollection<PlayList> PlayList { get; set; }
    }
}
