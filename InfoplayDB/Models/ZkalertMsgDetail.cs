using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ZkalertMsgDetail
    {
        public string AlertInfoId { get; set; }
        public int PlayerId { get; set; }
        public string DeviceId { get; set; }
        public int? IsSuccess { get; set; }
        public bool? IsReported { get; set; }
        public byte[] TimespanZk { get; set; }
        public int Id { get; set; }
    }
}
