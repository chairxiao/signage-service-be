using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class InfoServerService
    {
        public int Id { get; set; }
        public string InterfaceId { get; set; }
        public string Name { get; set; }
        public string Scheme { get; set; }
        public int? Port { get; set; }
        public string Path { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

        public virtual InfoServerInterface Interface { get; set; }
    }
}
