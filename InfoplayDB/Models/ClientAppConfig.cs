using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ClientAppConfig
    {
        public ClientAppConfig()
        {
            ClientAppUpdate = new HashSet<ClientAppUpdate>();
        }

        public int Id { get; set; }
        public string AppName { get; set; }
        public string InstallFolder { get; set; }
        public string UpdateUrl { get; set; }
        public bool? StartupByMonitor { get; set; }
        public bool? AutoStartup { get; set; }
        public string WindowServiceName { get; set; }
        public string AppVersion { get; set; }

        public virtual ICollection<ClientAppUpdate> ClientAppUpdate { get; set; }
    }
}
