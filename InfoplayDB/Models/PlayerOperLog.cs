using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PlayerOperLog
    {
        public long Id { get; set; }
        public int? PlayerId { get; set; }
        public int? CmdCode { get; set; }
        public string OperMemo { get; set; }
        public DateTime? ReqTime { get; set; }
        public int? State { get; set; }
        public DateTime? RetTime { get; set; }
        public string Remark { get; set; }
        public string StrData { get; set; }
    }
}
