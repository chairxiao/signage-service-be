using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PhotoListInfo
    {
        public int Id { get; set; }
        public int? ProgramId { get; set; }
        public string PhotoName { get; set; }
        public int? CountryCityId { get; set; }
        public int? Addby { get; set; }
        public DateTime? Adddate { get; set; }
        public int? PhotoNum { get; set; }
        public int? Intvl { get; set; }
        public string PlayType { get; set; }
    }
}
