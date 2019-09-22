using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class DataWeatherLink
    {
        public DataWeatherLink()
        {
            DataWeatherLinkStation = new HashSet<DataWeatherLinkStation>();
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public string DepartmentId { get; set; }

        public virtual ICollection<DataWeatherLinkStation> DataWeatherLinkStation { get; set; }
    }
}
