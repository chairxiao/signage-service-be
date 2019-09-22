using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayListShareManager
    {
        public PlayListShareManager()
        {
            PlayListShare = new HashSet<PlayListShare>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string PlayListType { get; set; }
        public string WindowType { get; set; }
        public int? CountryId { get; set; }
        public int? AddBy { get; set; }
        public DateTime? AddDate { get; set; }
        public string DepartmentId { get; set; }

        public virtual ICollection<PlayListShare> PlayListShare { get; set; }
    }
}
