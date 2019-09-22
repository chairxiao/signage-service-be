using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class RoleSpecialRightFilter
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? SpecialControlRightId { get; set; }
    }
}
