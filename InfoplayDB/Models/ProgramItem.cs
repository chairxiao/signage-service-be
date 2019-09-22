using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class ProgramItem
    {
        public ProgramItem()
        {
            CountryCityProgram = new HashSet<CountryCityProgram>();
            DownLoadDetail = new HashSet<DownLoadDetail>();
            LedProgramItem = new HashSet<LedProgramItem>();
            PhotoProgramItem = new HashSet<PhotoProgramItem>();
            PhotoProgramUploadInfo = new HashSet<PhotoProgramUploadInfo>();
            PlayList = new HashSet<PlayList>();
            PlayerProgram = new HashSet<PlayerProgram>();
            ProgramDetail = new HashSet<ProgramDetail>();
            RoleProgramFilter = new HashSet<RoleProgramFilter>();
            TemplateProgramItem = new HashSet<TemplateProgramItem>();
            TtsProgramItem = new HashSet<TtsProgramItem>();
            UserDefineProgram = new HashSet<UserDefineProgram>();
            UserProgramFilter = new HashSet<UserProgramFilter>();
            VideoProgramItem = new HashSet<VideoProgramItem>();
            VoiceProgramItem = new HashSet<VoiceProgramItem>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string HomeDirectory { get; set; }
        public string IndexPage { get; set; }
        public int? ViewWidth { get; set; }
        public int? ViewHeight { get; set; }
        public int? PlaySeconds { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public int? State { get; set; }
        public string Type { get; set; }
        public string Note { get; set; }
        public string CheckSum { get; set; }
        public string Uri { get; set; }
        public int? ProgramTypeId { get; set; }
        public string FitRegion { get; set; }
        public bool? InUse { get; set; }
        public DateTime? DeadTime { get; set; }
        public string W { get; set; }
        public string P { get; set; }
        public string T { get; set; }
        public string S { get; set; }
        public string A { get; set; }
        public string PlayTimeList { get; set; }
        public int? UpdateSeconds { get; set; }
        public int? PlayIntervalSeconds { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? EditType { get; set; }
        public int? AutoSize { get; set; }
        public int? OpenState { get; set; }
        public string Otherid { get; set; }
        public string Editmemo { get; set; }
        public string TreeFl { get; set; }
        public int? CountryCityId { get; set; }
        public DateTime? CheckProcessTime1 { get; set; }
        public DateTime? CheckProcessTime2 { get; set; }
        public bool? ProcessFlag { get; set; }
        public string ProcessStatus { get; set; }
        public DateTime? ProcessTime { get; set; }
        public string ProcessMsg { get; set; }
        public int? VersionId { get; set; }
        public string DepartmentId { get; set; }
        public int? UpdateWay { get; set; }
        public int? TotalFiles { get; set; }
        public int? TotalSize { get; set; }
        public int? AddBy { get; set; }
        public int? LastBy { get; set; }
        public string Cron { get; set; }
        public string Views { get; set; }
        public bool? IsTop { get; set; }
        public bool? Adaptive { get; set; }

        public virtual ProgramP PNavigation { get; set; }
        public virtual ProgramType ProgramType { get; set; }
        public virtual ProgramT TNavigation { get; set; }
        public virtual ProgramItemSuperComm ProgramItemSuperComm { get; set; }
        public virtual TemplateProgram TemplateProgram { get; set; }
        public virtual ICollection<CountryCityProgram> CountryCityProgram { get; set; }
        public virtual ICollection<DownLoadDetail> DownLoadDetail { get; set; }
        public virtual ICollection<LedProgramItem> LedProgramItem { get; set; }
        public virtual ICollection<PhotoProgramItem> PhotoProgramItem { get; set; }
        public virtual ICollection<PhotoProgramUploadInfo> PhotoProgramUploadInfo { get; set; }
        public virtual ICollection<PlayList> PlayList { get; set; }
        public virtual ICollection<PlayerProgram> PlayerProgram { get; set; }
        public virtual ICollection<ProgramDetail> ProgramDetail { get; set; }
        public virtual ICollection<RoleProgramFilter> RoleProgramFilter { get; set; }
        public virtual ICollection<TemplateProgramItem> TemplateProgramItem { get; set; }
        public virtual ICollection<TtsProgramItem> TtsProgramItem { get; set; }
        public virtual ICollection<UserDefineProgram> UserDefineProgram { get; set; }
        public virtual ICollection<UserProgramFilter> UserProgramFilter { get; set; }
        public virtual ICollection<VideoProgramItem> VideoProgramItem { get; set; }
        public virtual ICollection<VoiceProgramItem> VoiceProgramItem { get; set; }
    }
}
