using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class LedClient
    {
        public int Id { get; set; }
        public int ServerId { get; set; }
        public string LinkId { get; set; }
        public int LinkTypeId { get; set; }
        public int ControllerTypeId { get; set; }
        public string BindName { get; set; }
        public string Password { get; set; }
        public string Note { get; set; }
    }
}
