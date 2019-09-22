using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerTree
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public int IsLeaf { get; set; }
        public int PlayerId { get; set; }
        public int SortId { get; set; }
        public string Title { get; set; }
        public int? ZoneCityId { get; set; }
        public int? CountryCityId { get; set; }
        public string DepartmentId { get; set; }
        public string DId { get; set; }
    }
}
