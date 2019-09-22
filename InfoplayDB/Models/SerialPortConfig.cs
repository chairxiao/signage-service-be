using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class SerialPortConfig
    {
        public SerialPortConfig()
        {
            PlayerLedconfigGprsserialPort = new HashSet<PlayerLedconfig>();
            PlayerLedconfigSerialPort = new HashSet<PlayerLedconfig>();
        }

        public int SerialPortId { get; set; }
        public string PortType { get; set; }
        public int? PortName { get; set; }
        public int? DataBits { get; set; }
        public int? StopBits { get; set; }
        public bool? Parity { get; set; }
        public bool? FluidControl { get; set; }
        public int? BaudRate { get; set; }
        public int? DelayInterval { get; set; }
        public int? ReTry { get; set; }

        public virtual ICollection<PlayerLedconfig> PlayerLedconfigGprsserialPort { get; set; }
        public virtual ICollection<PlayerLedconfig> PlayerLedconfigSerialPort { get; set; }
    }
}
