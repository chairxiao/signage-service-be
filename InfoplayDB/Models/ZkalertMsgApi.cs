using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZkalertMsgApi
    {
        public int Id { get; set; }
        public string Indentifier { get; set; }
        public string Sender { get; set; }
        public string SeverityCnname { get; set; }
        public string Cityalias { get; set; }
        public string Severity { get; set; }
        public string Stationnum { get; set; }
        public string Publishdate { get; set; }
        public string Title { get; set; }
        public string CategoryCnname { get; set; }
        public string Alerttype { get; set; }
        public string DmType { get; set; }
        public string Content { get; set; }
        public string Contactcode { get; set; }
        public string Category { get; set; }
        public string DepartmentlevelCnname { get; set; }
        public string SenderCnname { get; set; }
        public string DmLevel { get; set; }
        public string Timestamp { get; set; }
        public string Departmentlevel { get; set; }
        public string Icon { get; set; }
        public string Areacode { get; set; }
        public DateTime? ReceiveTime { get; set; }
    }
}
