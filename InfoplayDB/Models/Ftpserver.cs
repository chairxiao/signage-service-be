using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Ftpserver
    {
        public int Id { get; set; }
        public string ServerName { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public string UserName { get; set; }
        public string Psw { get; set; }
        public string Path { get; set; }
    }
}
