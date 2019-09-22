using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class InfoServer
    {
        public InfoServer()
        {
            InfoServerInterface = new HashSet<InfoServerInterface>();
        }

        public string ServerId { get; set; }
        public string ServerName { get; set; }
        public string Ip { get; set; }
        public string ServerHost { get; set; }
        public string Note { get; set; }

        public virtual ICollection<InfoServerInterface> InfoServerInterface { get; set; }
    }
}
