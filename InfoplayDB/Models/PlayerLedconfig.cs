using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerLedconfig
    {
        public int Id { get; set; }
        public int? PlayerId { get; set; }
        public string CardModel { get; set; }
        public string CommunicationMethod { get; set; }
        public int? GprsserialPortId { get; set; }
        public int? SerialPortId { get; set; }
        public string Ip { get; set; }
        public int? Port { get; set; }
        public string Protocol { get; set; }
        public string Dtuid { get; set; }
        public int? Dtuport { get; set; }
        public string Dtucenter { get; set; }
        public string SimCard { get; set; }

        public virtual SerialPortConfig GprsserialPort { get; set; }
        public virtual Player Player { get; set; }
        public virtual SerialPortConfig SerialPort { get; set; }
    }
}
