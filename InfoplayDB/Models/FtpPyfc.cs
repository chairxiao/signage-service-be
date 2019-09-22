using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class FtpPyfc
    {
        public int Id { get; set; }
        public string ForeCastType { get; set; }
        public DateTime? ForecaseDate { get; set; }
        public string Icon { get; set; }
        public string MinT { get; set; }
        public string MaxT { get; set; }
        public string Fs { get; set; }
        public string Fx { get; set; }
        public string WeatherDesc { get; set; }
        public string FilterIcon1 { get; set; }
        public string FilterIcon2 { get; set; }
    }
}
