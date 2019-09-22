using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class UserDefineProgram
    {
        public int Id { get; set; }
        public int ProgramId { get; set; }
        public int StyleId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Content { get; set; }
        public DateTime? PlayTimeStart { get; set; }
        public DateTime? PlayTimeEnd { get; set; }
        public string PublishUnit { get; set; }
        public DateTime? PublishTime { get; set; }
        public bool? InUsed { get; set; }
        public int? CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public int? CountryCityId { get; set; }
        public string VerifyStatus { get; set; }
        public int? Verifier { get; set; }
        public string VerifyRemark { get; set; }
        public DateTime? VerifyDate { get; set; }

        public virtual CountryCity CountryCity { get; set; }
        public virtual ProgramItem Program { get; set; }
    }
}
