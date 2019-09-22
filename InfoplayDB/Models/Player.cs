using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class Player
    {
        public Player()
        {
            CountryCityPlayer = new HashSet<CountryCityPlayer>();
            Emergency = new HashSet<Emergency>();
            EmergencyAlertEvent = new HashSet<EmergencyAlertEvent>();
            Layout = new HashSet<Layout>();
            MobilePhone = new HashSet<MobilePhone>();
            PlayTimeTable = new HashSet<PlayTimeTable>();
            PlayerAutoStation = new HashSet<PlayerAutoStation>();
            PlayerFile = new HashSet<PlayerFile>();
            PlayerLedconfig = new HashSet<PlayerLedconfig>();
            PlayerLedfile = new HashSet<PlayerLedfile>();
            PlayerLedruntimeInfo = new HashSet<PlayerLedruntimeInfo>();
            PlayerLog = new HashSet<PlayerLog>();
            PlayerPhone = new HashSet<PlayerPhone>();
            PlayerProgram = new HashSet<PlayerProgram>();
            RolePlayerFilter = new HashSet<RolePlayerFilter>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string DisplayName { get; set; }
        public string Mac { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public DateTime? CheckTime { get; set; }
        public string CheckSum { get; set; }
        public bool? IsUpdated { get; set; }
        public DateTime? DownloadTime { get; set; }
        public int? CfgSize { get; set; }
        public string Note { get; set; }
        public byte[] VersionStamp { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public int? CountryCityId { get; set; }
        public bool? IsUsing { get; set; }
        public bool? IsEmergency { get; set; }
        public bool? AutoStartPlay { get; set; }
        public bool? ShutdownOutofPlayTime { get; set; }
        public string PId { get; set; }
        public string PTid { get; set; }
        public int? PelsWidth { get; set; }
        public int? PelsHeight { get; set; }
        public string DepartmentId { get; set; }
        public bool? IsBindSimCard { get; set; }
        public string DeviceId { get; set; }
        public string CountyId { get; set; }
        public int? ControlMode { get; set; }
        public int? UsingStatus { get; set; }
        public bool? IsTrumpet { get; set; }
        public int? StateAmp { get; set; }
        public int? StateMic { get; set; }
        public bool? IsZkclient { get; set; }
        public DateTime? InstallationDate { get; set; }
        public bool? IsUsing2 { get; set; }
        public int? NetworkType { get; set; }
        public string Address { get; set; }
        public int? Tvid { get; set; }
        public bool? IsUpZk { get; set; }

        public virtual CountryCity CountryCity { get; set; }
        public virtual PlayerConfig PlayerConfig { get; set; }
        public virtual PlayerStation PlayerStation { get; set; }
        public virtual ICollection<CountryCityPlayer> CountryCityPlayer { get; set; }
        public virtual ICollection<Emergency> Emergency { get; set; }
        public virtual ICollection<EmergencyAlertEvent> EmergencyAlertEvent { get; set; }
        public virtual ICollection<Layout> Layout { get; set; }
        public virtual ICollection<MobilePhone> MobilePhone { get; set; }
        public virtual ICollection<PlayTimeTable> PlayTimeTable { get; set; }
        public virtual ICollection<PlayerAutoStation> PlayerAutoStation { get; set; }
        public virtual ICollection<PlayerFile> PlayerFile { get; set; }
        public virtual ICollection<PlayerLedconfig> PlayerLedconfig { get; set; }
        public virtual ICollection<PlayerLedfile> PlayerLedfile { get; set; }
        public virtual ICollection<PlayerLedruntimeInfo> PlayerLedruntimeInfo { get; set; }
        public virtual ICollection<PlayerLog> PlayerLog { get; set; }
        public virtual ICollection<PlayerPhone> PlayerPhone { get; set; }
        public virtual ICollection<PlayerProgram> PlayerProgram { get; set; }
        public virtual ICollection<RolePlayerFilter> RolePlayerFilter { get; set; }
    }
}
