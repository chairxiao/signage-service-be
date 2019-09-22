using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class PhotoProgramUploadInfo
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public string PhotoName { get; set; }
        public int? CountryCityId { get; set; }
        public int? Addby { get; set; }
        public DateTime? Adddate { get; set; }
        public string VerifyStatus { get; set; }
        public string VerifyRemark { get; set; }
        public DateTime? VerifyDate { get; set; }
        public int? FileLength { get; set; }
        public int? Verifier { get; set; }

        public virtual ProgramItem Program { get; set; }
    }
}
