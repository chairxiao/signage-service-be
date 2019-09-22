using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class InfoServerInterface
    {
        public InfoServerInterface()
        {
            InfoServerService = new HashSet<InfoServerService>();
        }

        public string Id { get; set; }
        public string ServerId { get; set; }
        public string Ip { get; set; }
        public string Note { get; set; }
        public int? Prior { get; set; }

        public virtual InfoServer Server { get; set; }
        public virtual ICollection<InfoServerService> InfoServerService { get; set; }
    }
}
