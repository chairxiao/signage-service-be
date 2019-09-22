using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SysOptLog
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Ipaddress { get; set; }
        public DateTime AddDate { get; set; }
        public string Action { get; set; }
        public string Summary { get; set; }
    }
}
