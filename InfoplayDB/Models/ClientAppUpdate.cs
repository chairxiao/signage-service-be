using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ClientAppUpdate
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public int? AppConfigId { get; set; }
        public string UpdateState { get; set; }
        public DateTime? PublishTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public string AppVersion { get; set; }
        public string Status { get; set; }

        public virtual ClientAppConfig AppConfig { get; set; }
    }
}
