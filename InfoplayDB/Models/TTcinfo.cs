using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class TTcinfo
    {
        public int Tsid { get; set; }
        public string Tscname { get; set; }
        public string Tsename { get; set; }
        public string Intlid { get; set; }
        public string Intid { get; set; }
        public string Landon { get; set; }
        public string Landonid { get; set; }
        public string Pathtrend { get; set; }
        public string Origin { get; set; }
        public string Meanings { get; set; }
        public string Remark { get; set; }
        public string Ifgdfq { get; set; }
        public DateTime? Starttime { get; set; }
        public DateTime? Endtime { get; set; }
    }
}
