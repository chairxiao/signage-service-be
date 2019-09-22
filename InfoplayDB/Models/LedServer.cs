using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class LedServer
    {
        public int Id { get; set; }
        public string ServerName { get; set; }
        public string Title { get; set; }
        public string Ip1 { get; set; }
        public string Note { get; set; }
    }
}
