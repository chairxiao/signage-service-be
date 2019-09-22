using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class OrgDepartment
    {
        public string DepartmentId { get; set; }
        public string ParentDepartmentId { get; set; }
        public string DepartmentSign { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public string DepartmentOrder { get; set; }
        public int? DepartmentLevel { get; set; }
        public int? DepartmentStatus { get; set; }
        public string DepartmentIdex { get; set; }
        public string StaCode { get; set; }
        public string StaSign { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? LastModifyTime { get; set; }
        public double? Longtitude { get; set; }
        public double? Latitude { get; set; }
        public double? CityZoomlevel { get; set; }
        public string SubDepartmentName { get; set; }
    }
}
