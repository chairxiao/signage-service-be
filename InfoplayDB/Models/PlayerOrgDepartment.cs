using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerOrgDepartment
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string OrgDepartmentId { get; set; }
    }
}
