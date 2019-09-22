using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace InfoplayDB.Models
{
    public partial class InfoplayContext : DbContext
    {
        public InfoplayContext()
        {
        }

        public InfoplayContext(DbContextOptions<InfoplayContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CityForecast> CityForecast { get; set; }
        public virtual DbSet<CityForecastDetail> CityForecastDetail { get; set; }
        public virtual DbSet<CityForecastTask> CityForecastTask { get; set; }
        public virtual DbSet<CityForecastTaskStation> CityForecastTaskStation { get; set; }
        public virtual DbSet<CityLocation> CityLocation { get; set; }
        public virtual DbSet<ClientAppConfig> ClientAppConfig { get; set; }
        public virtual DbSet<ClientAppUpdate> ClientAppUpdate { get; set; }
        public virtual DbSet<ClientConfig> ClientConfig { get; set; }
        public virtual DbSet<ClientState> ClientState { get; set; }
        public virtual DbSet<CodeMaster> CodeMaster { get; set; }
        public virtual DbSet<ConfigStationFilter> ConfigStationFilter { get; set; }
        public virtual DbSet<ConfigStationInfo> ConfigStationInfo { get; set; }
        public virtual DbSet<ControlRights> ControlRights { get; set; }
        public virtual DbSet<CountryCity> CountryCity { get; set; }
        public virtual DbSet<CountryCityPlayer> CountryCityPlayer { get; set; }
        public virtual DbSet<CountryCityProgram> CountryCityProgram { get; set; }
        public virtual DbSet<DataHandlerUpdateEvent> DataHandlerUpdateEvent { get; set; }
        public virtual DbSet<DataHandlerUpdater> DataHandlerUpdater { get; set; }
        public virtual DbSet<DataWeatherLink> DataWeatherLink { get; set; }
        public virtual DbSet<DataWeatherLinkStation> DataWeatherLinkStation { get; set; }
        public virtual DbSet<DepartmentWeatherStation> DepartmentWeatherStation { get; set; }
        public virtual DbSet<DownLoadDetail> DownLoadDetail { get; set; }
        public virtual DbSet<Download> Download { get; set; }
        public virtual DbSet<DownloadTextFile> DownloadTextFile { get; set; }
        public virtual DbSet<DownloadTextFileTask> DownloadTextFileTask { get; set; }
        public virtual DbSet<Emergency> Emergency { get; set; }
        public virtual DbSet<EmergencyAlertEvent> EmergencyAlertEvent { get; set; }
        public virtual DbSet<FtpFileMonitor> FtpFileMonitor { get; set; }
        public virtual DbSet<FtpPyfc> FtpPyfc { get; set; }
        public virtual DbSet<FtpPyforecase> FtpPyforecase { get; set; }
        public virtual DbSet<FtpfileLog> FtpfileLog { get; set; }
        public virtual DbSet<Ftpserver> Ftpserver { get; set; }
        public virtual DbSet<Ftptask> Ftptask { get; set; }
        public virtual DbSet<GdcityForecast> GdcityForecast { get; set; }
        public virtual DbSet<GdcityForecastDetail> GdcityForecastDetail { get; set; }
        public virtual DbSet<InfoPlayerConfig> InfoPlayerConfig { get; set; }
        public virtual DbSet<InfoServer> InfoServer { get; set; }
        public virtual DbSet<InfoServerFile> InfoServerFile { get; set; }
        public virtual DbSet<InfoServerInterface> InfoServerInterface { get; set; }
        public virtual DbSet<InfoServerProgram> InfoServerProgram { get; set; }
        public virtual DbSet<InfoServerService> InfoServerService { get; set; }
        public virtual DbSet<IpLogin> IpLogin { get; set; }
        public virtual DbSet<Layout> Layout { get; set; }
        public virtual DbSet<LedClient> LedClient { get; set; }
        public virtual DbSet<LedControllerType> LedControllerType { get; set; }
        public virtual DbSet<LedLinkType> LedLinkType { get; set; }
        public virtual DbSet<LedProgramItem> LedProgramItem { get; set; }
        public virtual DbSet<LedServer> LedServer { get; set; }
        public virtual DbSet<LedUrlConfig> LedUrlConfig { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<LogLevel> LogLevel { get; set; }
        public virtual DbSet<LogSource> LogSource { get; set; }
        public virtual DbSet<MapStateInfo> MapStateInfo { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<MobilePhone> MobilePhone { get; set; }
        public virtual DbSet<MobilePhoneHis> MobilePhoneHis { get; set; }
        public virtual DbSet<MobileSmsRecv> MobileSmsRecv { get; set; }
        public virtual DbSet<NetworkType> NetworkType { get; set; }
        public virtual DbSet<NoteInfo> NoteInfo { get; set; }
        public virtual DbSet<OrgDepartment> OrgDepartment { get; set; }
        public virtual DbSet<PAlertMsg> PAlertMsg { get; set; }
        public virtual DbSet<PAlertMsgList> PAlertMsgList { get; set; }
        public virtual DbSet<PWeatherForecast> PWeatherForecast { get; set; }
        public virtual DbSet<PWeatherForecastCode> PWeatherForecastCode { get; set; }
        public virtual DbSet<PWeatherForecastMuiti> PWeatherForecastMuiti { get; set; }
        public virtual DbSet<PWeatherForecastMuitiCode> PWeatherForecastMuitiCode { get; set; }
        public virtual DbSet<PWeatherStation> PWeatherStation { get; set; }
        public virtual DbSet<PWeatherWeekly> PWeatherWeekly { get; set; }
        public virtual DbSet<PhotoListInfo> PhotoListInfo { get; set; }
        public virtual DbSet<PhotoProgramItem> PhotoProgramItem { get; set; }
        public virtual DbSet<PhotoProgramUploadInfo> PhotoProgramUploadInfo { get; set; }
        public virtual DbSet<PlayEffect> PlayEffect { get; set; }
        public virtual DbSet<PlayList> PlayList { get; set; }
        public virtual DbSet<PlayListShare> PlayListShare { get; set; }
        public virtual DbSet<PlayListShareManager> PlayListShareManager { get; set; }
        public virtual DbSet<PlayTimeTable> PlayTimeTable { get; set; }
        public virtual DbSet<PlayTimeTablebak> PlayTimeTablebak { get; set; }
        public virtual DbSet<Player> Player { get; set; }
        public virtual DbSet<PlayerAutoStation> PlayerAutoStation { get; set; }
        public virtual DbSet<PlayerConfig> PlayerConfig { get; set; }
        public virtual DbSet<PlayerConfig2> PlayerConfig2 { get; set; }
        public virtual DbSet<PlayerDownload> PlayerDownload { get; set; }
        public virtual DbSet<PlayerDownloadNotify> PlayerDownloadNotify { get; set; }
        public virtual DbSet<PlayerDownloadPublish> PlayerDownloadPublish { get; set; }
        public virtual DbSet<PlayerEvent> PlayerEvent { get; set; }
        public virtual DbSet<PlayerFile> PlayerFile { get; set; }
        public virtual DbSet<PlayerLedconfig> PlayerLedconfig { get; set; }
        public virtual DbSet<PlayerLedfile> PlayerLedfile { get; set; }
        public virtual DbSet<PlayerLedruntimeInfo> PlayerLedruntimeInfo { get; set; }
        public virtual DbSet<PlayerLinkStts> PlayerLinkStts { get; set; }
        public virtual DbSet<PlayerLinkSttsLog> PlayerLinkSttsLog { get; set; }
        public virtual DbSet<PlayerLog> PlayerLog { get; set; }
        public virtual DbSet<PlayerLoginLog> PlayerLoginLog { get; set; }
        public virtual DbSet<PlayerLoginLogBack> PlayerLoginLogBack { get; set; }
        public virtual DbSet<PlayerOperLog> PlayerOperLog { get; set; }
        public virtual DbSet<PlayerOrgDepartment> PlayerOrgDepartment { get; set; }
        public virtual DbSet<PlayerPhone> PlayerPhone { get; set; }
        public virtual DbSet<PlayerPlayListEvent> PlayerPlayListEvent { get; set; }
        public virtual DbSet<PlayerProgram> PlayerProgram { get; set; }
        public virtual DbSet<PlayerProgramPtss> PlayerProgramPtss { get; set; }
        public virtual DbSet<PlayerPublish> PlayerPublish { get; set; }
        public virtual DbSet<PlayerServer> PlayerServer { get; set; }
        public virtual DbSet<PlayerServerBack> PlayerServerBack { get; set; }
        public virtual DbSet<PlayerStation> PlayerStation { get; set; }
        public virtual DbSet<PlayerStatus> PlayerStatus { get; set; }
        public virtual DbSet<PlayerStatusBack> PlayerStatusBack { get; set; }
        public virtual DbSet<PlayerStatusHistory> PlayerStatusHistory { get; set; }
        public virtual DbSet<PlayerStatusHistoryD> PlayerStatusHistoryD { get; set; }
        public virtual DbSet<PlayerStatusLog> PlayerStatusLog { get; set; }
        public virtual DbSet<PlayerTask> PlayerTask { get; set; }
        public virtual DbSet<PlayerTree> PlayerTree { get; set; }
        public virtual DbSet<PlayerTreeIndex> PlayerTreeIndex { get; set; }
        public virtual DbSet<PlayerUploadFile> PlayerUploadFile { get; set; }
        public virtual DbSet<PlayerVersion> PlayerVersion { get; set; }
        public virtual DbSet<ProcessTask> ProcessTask { get; set; }
        public virtual DbSet<ProgramA> ProgramA { get; set; }
        public virtual DbSet<ProgramDataTask> ProgramDataTask { get; set; }
        public virtual DbSet<ProgramDetail> ProgramDetail { get; set; }
        public virtual DbSet<ProgramFile> ProgramFile { get; set; }
        public virtual DbSet<ProgramFileUri> ProgramFileUri { get; set; }
        public virtual DbSet<ProgramItem> ProgramItem { get; set; }
        public virtual DbSet<ProgramItemSuperComm> ProgramItemSuperComm { get; set; }
        public virtual DbSet<ProgramLedfile> ProgramLedfile { get; set; }
        public virtual DbSet<ProgramP> ProgramP { get; set; }
        public virtual DbSet<ProgramPublish> ProgramPublish { get; set; }
        public virtual DbSet<ProgramS> ProgramS { get; set; }
        public virtual DbSet<ProgramT> ProgramT { get; set; }
        public virtual DbSet<ProgramType> ProgramType { get; set; }
        public virtual DbSet<ProgramW> ProgramW { get; set; }
        public virtual DbSet<RadorImageFile> RadorImageFile { get; set; }
        public virtual DbSet<RadorImageTask> RadorImageTask { get; set; }
        public virtual DbSet<RadorImageTaskSaveFile> RadorImageTaskSaveFile { get; set; }
        public virtual DbSet<RecvAlertMsgListEvent> RecvAlertMsgListEvent { get; set; }
        public virtual DbSet<RecvWeatherForecast> RecvWeatherForecast { get; set; }
        public virtual DbSet<RecvWeatherForecastAdded> RecvWeatherForecastAdded { get; set; }
        public virtual DbSet<RecvWeatherForecastDetail> RecvWeatherForecastDetail { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<RoleCountryCityFilter> RoleCountryCityFilter { get; set; }
        public virtual DbSet<RolePlayerFilter> RolePlayerFilter { get; set; }
        public virtual DbSet<RoleProgramFilter> RoleProgramFilter { get; set; }
        public virtual DbSet<RoleRightFilter> RoleRightFilter { get; set; }
        public virtual DbSet<RoleSpecialRightFilter> RoleSpecialRightFilter { get; set; }
        public virtual DbSet<RoleType> RoleType { get; set; }
        public virtual DbSet<SerialPortConfig> SerialPortConfig { get; set; }
        public virtual DbSet<SmsAlertEvent> SmsAlertEvent { get; set; }
        public virtual DbSet<SmsEvent> SmsEvent { get; set; }
        public virtual DbSet<SmsEventRaise> SmsEventRaise { get; set; }
        public virtual DbSet<SmsLinkUser> SmsLinkUser { get; set; }
        public virtual DbSet<SmsSend> SmsSend { get; set; }
        public virtual DbSet<SmsUser> SmsUser { get; set; }
        public virtual DbSet<SpecialControlRight> SpecialControlRight { get; set; }
        public virtual DbSet<StationFtp> StationFtp { get; set; }
        public virtual DbSet<Stationdata> Stationdata { get; set; }
        public virtual DbSet<Stationinfo> Stationinfo { get; set; }
        public virtual DbSet<SurfGrmcMulHour> SurfGrmcMulHour { get; set; }
        public virtual DbSet<SurfGrmcMulHourNew> SurfGrmcMulHourNew { get; set; }
        public virtual DbSet<SysOptLog> SysOptLog { get; set; }
        public virtual DbSet<TTcObs> TTcObs { get; set; }
        public virtual DbSet<TTcObsForecase> TTcObsForecase { get; set; }
        public virtual DbSet<TTcinfo> TTcinfo { get; set; }
        public virtual DbSet<TaskClientState> TaskClientState { get; set; }
        public virtual DbSet<TaskQue> TaskQue { get; set; }
        public virtual DbSet<TempRadorImageFile> TempRadorImageFile { get; set; }
        public virtual DbSet<Template> Template { get; set; }
        public virtual DbSet<TemplateParams> TemplateParams { get; set; }
        public virtual DbSet<TemplateProgram> TemplateProgram { get; set; }
        public virtual DbSet<TemplateProgramItem> TemplateProgramItem { get; set; }
        public virtual DbSet<TemplateStyle> TemplateStyle { get; set; }
        public virtual DbSet<Test1> Test1 { get; set; }
        public virtual DbSet<TestTable1> TestTable1 { get; set; }
        public virtual DbSet<TownsInfo> TownsInfo { get; set; }
        public virtual DbSet<TtsProgramItem> TtsProgramItem { get; set; }
        public virtual DbSet<Tvconfig> Tvconfig { get; set; }
        public virtual DbSet<UserDefineProgram> UserDefineProgram { get; set; }
        public virtual DbSet<UserDefineStyle> UserDefineStyle { get; set; }
        public virtual DbSet<UserIpLogin> UserIpLogin { get; set; }
        public virtual DbSet<UserLog> UserLog { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserProgramFilter> UserProgramFilter { get; set; }
        public virtual DbSet<UserRoleFilter> UserRoleFilter { get; set; }
        public virtual DbSet<UserSet> UserSet { get; set; }
        public virtual DbSet<VerifyManage> VerifyManage { get; set; }
        public virtual DbSet<VerifyProcess> VerifyProcess { get; set; }
        public virtual DbSet<VerifyStatus> VerifyStatus { get; set; }
        public virtual DbSet<VerifyType> VerifyType { get; set; }
        public virtual DbSet<VersionInfo> VersionInfo { get; set; }
        public virtual DbSet<VideoProgramItem> VideoProgramItem { get; set; }
        public virtual DbSet<VirtualStation> VirtualStation { get; set; }
        public virtual DbSet<VoiceProgramItem> VoiceProgramItem { get; set; }
        public virtual DbSet<WeatherComCity> WeatherComCity { get; set; }
        public virtual DbSet<WeatherComForecast> WeatherComForecast { get; set; }
        public virtual DbSet<WeatherMulDay> WeatherMulDay { get; set; }
        public virtual DbSet<WeatherMulHour> WeatherMulHour { get; set; }
        public virtual DbSet<WeatherMulLatest> WeatherMulLatest { get; set; }
        public virtual DbSet<WeatherStation> WeatherStation { get; set; }
        public virtual DbSet<WebTask> WebTask { get; set; }
        public virtual DbSet<WebTaskType> WebTaskType { get; set; }
        public virtual DbSet<Window> Window { get; set; }
        public virtual DbSet<WindowType> WindowType { get; set; }
        public virtual DbSet<ZkalertMsg> ZkalertMsg { get; set; }
        public virtual DbSet<ZkalertMsgApi> ZkalertMsgApi { get; set; }
        public virtual DbSet<ZkalertMsgDetail> ZkalertMsgDetail { get; set; }
        public virtual DbSet<ZkalertMsgProgram> ZkalertMsgProgram { get; set; }
        public virtual DbSet<ZkalertMsgStat> ZkalertMsgStat { get; set; }
        public virtual DbSet<ZkmsgPlayerJson> ZkmsgPlayerJson { get; set; }
        public virtual DbSet<ZkplayerStatusReport> ZkplayerStatusReport { get; set; }
        public virtual DbSet<ZkreceivedMsg> ZkreceivedMsg { get; set; }
        public virtual DbSet<ZktestMsg> ZktestMsg { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }
        public virtual DbSet<ZoneCity> ZoneCity { get; set; }

        // Unable to generate entity type for table 'dbo.FlvTransHis'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.player_type'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.P_AlertMsg_Code'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.P_AlertMsg_ColorCode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.whxphDate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.User_Programe_Style'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AsianGamesFile'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AsianGamesSite'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BroadcastInfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.OrgDepartmentProgram'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SURF_GRMC_MUL_DAY'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.phone'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PlayListShareType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.LayoutWindow'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Province'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Towns'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Message'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Remote_AutoStation_filter'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.zxl'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Map_CongHua'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Player_AlertStation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Map_GuangDong'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Map_GuangZhou'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WeatherFore'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.P_AlertMsg_Station'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.WeatherForeFX'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TemplateRefFile'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.City'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TemplateProgramParams'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.P_AlertMsgDetail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PlayerDownloadBack'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.11.2.82;Database=Infoplay;User=hua;Password=hua637638");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<CityForecast>(entity =>
            {
                entity.HasKey(e => e.ForecastId)
                    .HasName("PK_GDCityForecast");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ForeCastRegion)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ForeCastTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CityForecastDetail>(entity =>
            {
                entity.HasKey(e => e.ForecastDetailId);

                entity.Property(e => e.ForeCastType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fs)
                    .IsRequired()
                    .HasColumnName("FS")
                    .HasMaxLength(100);

                entity.Property(e => e.Fx)
                    .IsRequired()
                    .HasColumnName("FX")
                    .HasMaxLength(100);

                entity.Property(e => e.MaxT).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.MinT).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.StaCode)
                    .HasColumnName("staCode")
                    .HasMaxLength(50);

                entity.Property(e => e.WeatherDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Forecast)
                    .WithMany(p => p.CityForecastDetail)
                    .HasForeignKey(d => d.ForecastId)
                    .HasConstraintName("FK_CityForecastDetail_CityForecast");
            });

            modelBuilder.Entity<CityForecastTask>(entity =>
            {
                entity.HasKey(e => e.ForeCaseId);

                entity.ToTable("CityForecast_Task");

                entity.Property(e => e.ForeCaseId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CityForecastTaskStation>(entity =>
            {
                entity.HasKey(e => e.StaCode);

                entity.ToTable("CityForecast_TaskStation");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<CityLocation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CityX).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.CityY).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<ClientAppConfig>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InstallFolder)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateUrl)
                    .HasColumnName("UpdateURL")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.WindowServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientAppUpdate>(entity =>
            {
                entity.HasIndex(e => e.PlayerId);

                entity.HasIndex(e => e.UpdateState);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PublishTime).HasColumnType("datetime");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.UpdateState)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AppConfig)
                    .WithMany(p => p.ClientAppUpdate)
                    .HasForeignKey(d => d.AppConfigId)
                    .HasConstraintName("FK_ClientAppUpdate_ClientAppUpdate");
            });

            modelBuilder.Entity<ClientConfig>(entity =>
            {
                entity.HasKey(e => e.Mac);

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.PlayStartTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PlayStopTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PowerOffTime).HasColumnType("smalldatetime");

                entity.Property(e => e.PowerOnTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ScreenOffTime).HasColumnType("smalldatetime");

                entity.Property(e => e.ScreenOnTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClientState>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<CodeMaster>(entity =>
            {
                entity.HasKey(e => new { e.CodeKey, e.Value })
                    .HasName("PK_CodeMaster_1");

                entity.Property(e => e.CodeKey)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasDefaultValueSql("((1))");

                entity.Property(e => e.Remark)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SeqNo).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<ConfigStationFilter>(entity =>
            {
                entity.ToTable("Config_StationFilter");

                entity.HasIndex(e => e.ZoneCode)
                    .HasName("IX_Config_StationFilter");

                entity.Property(e => e.FilterType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.ZoneCodeNavigation)
                    .WithMany(p => p.ConfigStationFilter)
                    .HasForeignKey(d => d.ZoneCode)
                    .HasConstraintName("FK_Config_StationFilter_Config_StationInfo");
            });

            modelBuilder.Entity<ConfigStationInfo>(entity =>
            {
                entity.HasKey(e => e.ZoneCode)
                    .HasName("PK_Config_StationInfo_1");

                entity.ToTable("Config_StationInfo");

                entity.HasIndex(e => e.ZoneCode)
                    .HasName("IX_Config_StationInfo");

                entity.Property(e => e.ZoneCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ZoneName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ControlRights>(entity =>
            {
                entity.HasKey(e => e.RightId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ModelId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentFolder)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RightCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RightDesc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RightName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CountryCity>(entity =>
            {
                entity.HasKey(e => e.CountryCityId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CountryName).HasMaxLength(50);

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StaSign).HasMaxLength(10);

                entity.HasOne(d => d.StaCodeNavigation)
                    .WithMany(p => p.CountryCity)
                    .HasForeignKey(d => d.StaCode)
                    .HasConstraintName("FK_CountryCity_STATIONINFO");

                entity.HasOne(d => d.ZoneCity)
                    .WithMany(p => p.CountryCity)
                    .HasForeignKey(d => d.ZoneCityId)
                    .HasConstraintName("FK_CountryCity_ZoneCity");
            });

            modelBuilder.Entity<CountryCityPlayer>(entity =>
            {
                entity.HasKey(e => new { e.CountryCityId, e.PlayerId });

                entity.ToTable("CountryCity_Player");

                entity.HasOne(d => d.CountryCity)
                    .WithMany(p => p.CountryCityPlayer)
                    .HasForeignKey(d => d.CountryCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryCity_Player_CountryCity");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.CountryCityPlayer)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryCity_Player_Player");
            });

            modelBuilder.Entity<CountryCityProgram>(entity =>
            {
                entity.HasKey(e => new { e.CountryCityId, e.ProgramId });

                entity.ToTable("CountryCity_Program");

                entity.HasOne(d => d.CountryCity)
                    .WithMany(p => p.CountryCityProgram)
                    .HasForeignKey(d => d.CountryCityId)
                    .HasConstraintName("FK_CountryCity_Program_CountryCity");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.CountryCityProgram)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_CountryCity_Program_ProgramItem");
            });

            modelBuilder.Entity<DataHandlerUpdateEvent>(entity =>
            {
                entity.HasIndex(e => e.IsUpdated)
                    .HasName("IX_DataHandlerUpdateEvent_IsUpdate");

                entity.HasIndex(e => e.RecTime);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProcTime).HasColumnType("datetime");

                entity.Property(e => e.RecTime).HasColumnType("datetime");

                entity.Property(e => e.UriKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataHandlerUpdater>(entity =>
            {
                entity.HasIndex(e => e.ProcTime);

                entity.HasIndex(e => e.RecTime);

                entity.HasIndex(e => e.Retrys);

                entity.HasIndex(e => e.UriKey);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PlayerIds).IsUnicode(false);

                entity.Property(e => e.ProcTime).HasColumnType("smalldatetime");

                entity.Property(e => e.RecTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.UriKey)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DataWeatherLink>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(512);

                entity.Property(e => e.Title).HasMaxLength(256);
            });

            modelBuilder.Entity<DataWeatherLinkStation>(entity =>
            {
                entity.ToTable("DataWeatherLink_Station");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LinkId)
                    .HasColumnName("LinkID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StaCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Link)
                    .WithMany(p => p.DataWeatherLinkStation)
                    .HasForeignKey(d => d.LinkId)
                    .HasConstraintName("FK_DATAWEAT_REFERENCE_DATAWEAT");
            });

            modelBuilder.Entity<DepartmentWeatherStation>(entity =>
            {
                entity.HasKey(e => new { e.DepartmentId, e.StaCode })
                    .HasName("PK_DEPARTMENT_WEATHER_STATION");

                entity.ToTable("Department_Weather_Station");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StaCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownLoadDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DownloadPath)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReplaceKey)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequirePlayerId)
                    .HasColumnName("RequirePlayerID")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.DownLoadDetail)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_DownLoadDetail_ProgramItem");
            });

            modelBuilder.Entity<Download>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RequestUri)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadTextFile>(entity =>
            {
                entity.HasKey(e => new { e.DownloadType, e.FileName })
                    .HasName("PK_SZFileData");

                entity.Property(e => e.DownloadType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content).HasColumnType("ntext");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.FileType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DownloadTextFileTask>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DownloadType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaveFileName).HasMaxLength(500);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Emergency>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.LastTime).HasColumnType("datetime");

                entity.Property(e => e.OptionFlag).HasMaxLength(10);

                entity.Property(e => e.PlayBeginTime).HasColumnType("datetime");

                entity.Property(e => e.PlayEndTime).HasColumnType("datetime");

                entity.Property(e => e.PlayType).HasMaxLength(10);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Emergency)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_EMERGENC_REFERENCE_PLAYER");
            });

            modelBuilder.Entity<EmergencyAlertEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_EMERGENCY_ALERTEVENT");

                entity.ToTable("Emergency_AlertEvent");

                entity.Property(e => e.AlertCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AlertColorCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StaSign)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.EmergencyAlertEvent)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_Emergency_AlertEvent_Player");
            });

            modelBuilder.Entity<FtpFileMonitor>(entity =>
            {
                entity.ToTable("FTP_FileMonitor");

                entity.HasIndex(e => new { e.FileType, e.FileName, e.FileModifyTime })
                    .HasName("IX_FTP_FileMonitor");

                entity.Property(e => e.FileModifyTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FtpPyfc>(entity =>
            {
                entity.ToTable("FTP_PYFC");

                entity.Property(e => e.FilterIcon1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilterIcon2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForeCastType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForecaseDate).HasColumnType("datetime");

                entity.Property(e => e.Fs)
                    .HasColumnName("FS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fx)
                    .HasColumnName("FX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaxT)
                    .HasColumnName("maxT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MinT)
                    .HasColumnName("minT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WeatherDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FtpPyforecase>(entity =>
            {
                entity.ToTable("FTP_PYForecase");

                entity.Property(e => e.Desc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForecastCurDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ForecastDate).HasColumnType("datetime");

                entity.Property(e => e.ForecastType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Week)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FtpfileLog>(entity =>
            {
                entity.ToTable("FTPFileLog");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Ftpserver>(entity =>
            {
                entity.ToTable("FTPServer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Port)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Psw)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ServerName)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ftptask>(entity =>
            {
                entity.ToTable("FTPTask");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FtpTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FtpserverId).HasColumnName("FTPServerId");

                entity.Property(e => e.LastReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.TaskName).HasMaxLength(100);
            });

            modelBuilder.Entity<GdcityForecast>(entity =>
            {
                entity.HasKey(e => e.ForecastId)
                    .HasName("PK_GDCityForecast1");

                entity.ToTable("GDCityForecast");

                entity.Property(e => e.BeginTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ForeCastMan)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ForeCastText)
                    .IsRequired()
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.ForeCastTime).HasColumnType("datetime");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<GdcityForecastDetail>(entity =>
            {
                entity.HasKey(e => e.ForecastDetailId);

                entity.ToTable("GDCityForecastDetail");

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.ForeCastType)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WeatherDesc)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Forecast)
                    .WithMany(p => p.GdcityForecastDetail)
                    .HasForeignKey(d => d.ForecastId)
                    .HasConstraintName("FK_GDCityForecastDetail_GDCityForecast");
            });

            modelBuilder.Entity<InfoPlayerConfig>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FollowParams).HasMaxLength(500);

                entity.Property(e => e.TransparencyKey)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfoServer>(entity =>
            {
                entity.HasKey(e => e.ServerId)
                    .HasName("PK_INFOSERVER");

                entity.Property(e => e.ServerId)
                    .HasColumnName("ServerID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(50);

                entity.Property(e => e.ServerHost)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ServerName).HasMaxLength(64);
            });

            modelBuilder.Entity<InfoServerFile>(entity =>
            {
                entity.HasIndex(e => new { e.ServerId, e.FileId })
                    .HasName("IX_InfoServerFile")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .IsUnicode(false);

                entity.Property(e => e.ServerId)
                    .HasColumnName("ServerID")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfoServerInterface>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(250);

                entity.Property(e => e.ServerId)
                    .HasColumnName("ServerID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.InfoServerInterface)
                    .HasForeignKey(d => d.ServerId)
                    .HasConstraintName("FK_INFOSERV_REFERENCE_INFOSERV");
            });

            modelBuilder.Entity<InfoServerProgram>(entity =>
            {
                entity.HasIndex(e => e.IsUpdated)
                    .HasName("IX_InfoServerProgram_IsUpdate");

                entity.HasIndex(e => e.ServerId);

                entity.HasIndex(e => new { e.ServerId, e.ProgramId })
                    .HasName("IX_InfoServerProgram")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .IsUnicode(false);

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");

                entity.Property(e => e.ServerId)
                    .HasColumnName("ServerID")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InfoServerService>(entity =>
            {
                entity.ToTable("InfoServer_Service");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InterfaceId)
                    .HasColumnName("InterfaceID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasColumnName("path")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.Port).HasColumnName("port");

                entity.Property(e => e.Scheme)
                    .HasColumnName("scheme")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Interface)
                    .WithMany(p => p.InfoServerService)
                    .HasForeignKey(d => d.InterfaceId)
                    .HasConstraintName("FK_SInterface_REFERENCE_SService");
            });

            modelBuilder.Entity<IpLogin>(entity =>
            {
                entity.HasKey(e => e.Ip);

                entity.ToTable("IP_Login");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.HasOne(d => d.CountryCity)
                    .WithMany(p => p.IpLogin)
                    .HasForeignKey(d => d.CountryCityId)
                    .HasConstraintName("FK_IP_Login_CountryCity");
            });

            modelBuilder.Entity<Layout>(entity =>
            {
                entity.HasIndex(e => e.Enable);

                entity.HasIndex(e => e.PlayerId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BackgroundPicture)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundSound)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Layout)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Layout_Player1");
            });

            modelBuilder.Entity<LedClient>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BindName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LedControllerType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Note).HasMaxLength(10);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LedLinkType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Note).HasMaxLength(10);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LedProgramItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Align)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((-1))");

                entity.Property(e => e.ConfigData).HasMaxLength(50);

                entity.Property(e => e.ConfigType).HasMaxLength(50);

                entity.Property(e => e.FontSize).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PlayEffect).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PlayInfo)
                    .HasColumnName("playInfo")
                    .HasMaxLength(1000);

                entity.Property(e => e.PlayTitle)
                    .HasColumnName("playTitle")
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.LedProgramItem)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_LedProgramItem_ProgramItem");
            });

            modelBuilder.Entity<LedServer>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ip1)
                    .HasColumnName("IP1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).IsUnicode(false);

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LedUrlConfig>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataUrl)
                    .HasColumnName("dataUrl")
                    .HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(100);

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.Property(e => e.App)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Thread)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogLevel>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LevelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogSource>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MapStateInfo>(entity =>
            {
                entity.ToTable("Map_StateInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressName)
                    .HasColumnName("Address_name")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressPhoto)
                    .HasColumnName("Address_photo")
                    .HasMaxLength(10);

                entity.Property(e => e.BlX)
                    .HasColumnName("bl_x")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.BlY)
                    .HasColumnName("bl_y")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TrX)
                    .HasColumnName("tr_x")
                    .HasColumnType("decimal(18, 3)");

                entity.Property(e => e.TrY)
                    .HasColumnName("tr_y")
                    .HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<Menu>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.EntityId)
                    .HasColumnName("EntityID")
                    .HasMaxLength(40);

                entity.Property(e => e.Href).HasMaxLength(255);

                entity.Property(e => e.Icon).HasMaxLength(50);

                entity.Property(e => e.IconHover).HasMaxLength(50);

                entity.Property(e => e.NameText).HasMaxLength(128);

                entity.Property(e => e.ParentId)
                    .HasColumnName("ParentID")
                    .HasMaxLength(40);

                entity.Property(e => e.RightCode).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(128);

                entity.Property(e => e.Updated).HasColumnType("datetime");
            });

            modelBuilder.Entity<MobilePhone>(entity =>
            {
                entity.HasKey(e => e.SimCardSn);

                entity.Property(e => e.SimCardSn)
                    .HasColumnName("SimCardSN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Balance).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BasicBalance).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.CountryCityId).HasColumnName("CountryCityID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.GprsSet).HasMaxLength(50);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(400);

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.PresentBalance).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.SurplusFlow).HasMaxLength(50);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.MobilePhone)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_MOBILEPH_REFERENCE_PLAYER");
            });

            modelBuilder.Entity<MobilePhoneHis>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BasicBalance).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.CountryCityId).HasColumnName("CountryCityID");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.GprsSet).HasMaxLength(50);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note).HasMaxLength(400);

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.PresentBalance).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.SurplusFlow).HasMaxLength(50);
            });

            modelBuilder.Entity<MobileSmsRecv>(entity =>
            {
                entity.HasIndex(e => new { e.PlayerId, e.Sender, e.RecvTime })
                    .HasName("IX_MobileSmsRecv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.ProcessMsg).HasMaxLength(500);

                entity.Property(e => e.RecvTime).HasColumnType("datetime");

                entity.Property(e => e.Sender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimCardSn)
                    .HasColumnName("SimCardSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmsContent).HasMaxLength(4000);
            });

            modelBuilder.Entity<NetworkType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<NoteInfo>(entity =>
            {
                entity.HasKey(e => e.NoteIndoId);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.PublishDate).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrgDepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentDescription)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentIdex)
                    .HasColumnName("DepartmentIDEx")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentOrder).HasMaxLength(32);

                entity.Property(e => e.DepartmentSign)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastModifyTime).HasColumnType("datetime");

                entity.Property(e => e.ParentDepartmentId)
                    .HasColumnName("ParentDepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaSign)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubDepartmentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PAlertMsg>(entity =>
            {
                entity.HasKey(e => e.RecvAlertMsgId)
                    .HasName("PK_RecvAlertMsg");

                entity.ToTable("P_AlertMsg");

                entity.Property(e => e.AlertMsgCode).HasMaxLength(50);

                entity.Property(e => e.AlertMsgText).HasMaxLength(200);

                entity.Property(e => e.AlertMsgTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgHeaderTime).HasColumnType("datetime");

                entity.Property(e => e.RecvTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StaSign)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PAlertMsgList>(entity =>
            {
                entity.ToTable("P_AlertMsgList");

                entity.HasIndex(e => new { e.StaSign, e.MsgCode, e.MsgColorCode })
                    .HasName("IX_P_AlertMsgList")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgColorCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgDateTime).HasColumnType("datetime");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaSign)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PWeatherForecast>(entity =>
            {
                entity.ToTable("P_WeatherForecast");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CoastalTyphoon)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoastalWind)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataSource).HasMaxLength(50);

                entity.Property(e => e.EffectiveBeginTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEndTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTime)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fcode)
                    .IsRequired()
                    .HasColumnName("FCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fgcode2)
                    .IsRequired()
                    .HasColumnName("FGCode2")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fgtext)
                    .HasColumnName("FGText")
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ForeCastBeginTime).HasColumnType("datetime");

                entity.Property(e => e.ForeCastEndTime).HasColumnType("datetime");

                entity.Property(e => e.ForeCastTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fs)
                    .IsRequired()
                    .HasColumnName("FS")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fx)
                    .IsRequired()
                    .HasColumnName("FX")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StaCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStampV)
                    .HasColumnName("TimeStamp_V")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WeatherDesc)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PWeatherForecastCode>(entity =>
            {
                entity.HasKey(e => e.Fccode);

                entity.ToTable("P_WeatherForecast_Code");

                entity.Property(e => e.Fccode)
                    .HasColumnName("FCCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Fcterm)
                    .IsRequired()
                    .HasColumnName("FCTerm")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PWeatherForecastMuiti>(entity =>
            {
                entity.ToTable("P_WeatherForecastMuiti");

                entity.HasIndex(e => new { e.StaCode, e.ForeCastEndTime })
                    .HasName("IX_P_WeatherForecastMuiti");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DataSource).HasMaxLength(50);

                entity.Property(e => e.EffectiveBeginTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveEndTime).HasColumnType("datetime");

                entity.Property(e => e.EffectiveTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fgtext)
                    .HasColumnName("FGText")
                    .HasMaxLength(4000)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlashCode24)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlashCode48)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FlashCode72)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ForeCastBeginTime).HasColumnType("datetime");

                entity.Property(e => e.ForeCastEndTime).HasColumnType("datetime");

                entity.Property(e => e.ForeCastTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StaCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TimeStampV)
                    .HasColumnName("TimeStamp_V")
                    .IsRowVersion();

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WeatherDesc24)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WeatherDesc48)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WeatherDesc72)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PWeatherForecastMuitiCode>(entity =>
            {
                entity.HasKey(e => e.Fgcode);

                entity.ToTable("P_WeatherForecastMuiti_Code");

                entity.Property(e => e.Fgcode)
                    .HasColumnName("FGCode")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Fgname)
                    .IsRequired()
                    .HasColumnName("FGName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PWeatherStation>(entity =>
            {
                entity.HasKey(e => e.StaCode)
                    .HasName("PK_P_WEATHER_STATION");

                entity.ToTable("P_Weather_Station");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Note).HasMaxLength(32);

                entity.Property(e => e.ParentStaCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StaName).HasMaxLength(50);
            });

            modelBuilder.Entity<PWeatherWeekly>(entity =>
            {
                entity.ToTable("P_Weather_Weekly");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Page1)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Page2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Page3)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Page4)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Page5)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ReleaseTime).HasColumnType("datetime");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VerifyStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.StaCodeNavigation)
                    .WithMany(p => p.PWeatherWeekly)
                    .HasForeignKey(d => d.StaCode)
                    .HasConstraintName("FK_P_Weather_Weekly_STATIONINFO");
            });

            modelBuilder.Entity<PhotoListInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adddate).HasColumnType("datetime");

                entity.Property(e => e.PhotoName).HasMaxLength(50);

                entity.Property(e => e.PlayType).HasMaxLength(50);
            });

            modelBuilder.Entity<PhotoProgramItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.PhotoName).HasMaxLength(50);

                entity.Property(e => e.PlayType).HasMaxLength(50);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PhotoProgramItem)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_PhotoListInfo_ProgramItem");
            });

            modelBuilder.Entity<PhotoProgramUploadInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Adddate).HasColumnType("datetime");

                entity.Property(e => e.PhotoName).HasMaxLength(50);

                entity.Property(e => e.VerifyDate).HasColumnType("datetime");

                entity.Property(e => e.VerifyRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PhotoProgramUploadInfo)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_PhotoProgramUploadInfo_ProgramItem");
            });

            modelBuilder.Entity<PlayEffect>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Effect).HasMaxLength(50);
            });

            modelBuilder.Entity<PlayList>(entity =>
            {
                entity.HasIndex(e => e.Enable);

                entity.HasIndex(e => e.ProgramId);

                entity.HasIndex(e => e.WindowId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PlayList)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayList_ProgramItem");

                entity.HasOne(d => d.Window)
                    .WithMany(p => p.PlayList)
                    .HasForeignKey(d => d.WindowId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayList_Window");
            });

            modelBuilder.Entity<PlayListShare>(entity =>
            {
                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Manager)
                    .WithMany(p => p.PlayListShare)
                    .HasForeignKey(d => d.ManagerId)
                    .HasConstraintName("FK_PlayListShare_PlayListShareManager");
            });

            modelBuilder.Entity<PlayListShareManager>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PlayListType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WindowType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayTimeTable>(entity =>
            {
                entity.HasIndex(e => e.PlayerId)
                    .HasName("IX_PlayTimeTable_PlayerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StartPlayTime).HasColumnType("datetime");

                entity.Property(e => e.StopPlayTime).HasColumnType("datetime");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayTimeTable)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayTimeTable_Player");
            });

            modelBuilder.Entity<PlayTimeTablebak>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.StartPlayTime).HasColumnType("datetime");

                entity.Property(e => e.StopPlayTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.Mac)
                    .HasName("IX_Player")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.CountyId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(54)
                    .IsUnicode(false);

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.InstallationDate).HasColumnType("datetime");

                entity.Property(e => e.IsTrumpet).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUpZk)
                    .HasColumnName("IsUpZK")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsUsing).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsZkclient).HasColumnName("IsZKClient");

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PId)
                    .HasColumnName("pId")
                    .HasMaxLength(20);

                entity.Property(e => e.PTid)
                    .HasColumnName("pTid")
                    .HasMaxLength(20);

                entity.Property(e => e.StateAmp).HasDefaultValueSql("((0))");

                entity.Property(e => e.StateMic).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tvid).HasColumnName("TVId");

                entity.Property(e => e.VersionStamp)
                    .HasColumnName("versionStamp")
                    .IsRowVersion();

                entity.HasOne(d => d.CountryCity)
                    .WithMany(p => p.Player)
                    .HasForeignKey(d => d.CountryCityId)
                    .HasConstraintName("FK_Player_CountryCity");
            });

            modelBuilder.Entity<PlayerAutoStation>(entity =>
            {
                entity.ToTable("Player_AutoStation");

                entity.Property(e => e.PlayerId).HasDefaultValueSql("((0))");

                entity.Property(e => e.StaCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerAutoStation)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Player_AutoStation_Player");

                entity.HasOne(d => d.StaCodeNavigation)
                    .WithMany(p => p.PlayerAutoStation)
                    .HasForeignKey(d => d.StaCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Player_AutoStation_STATIONINFO");
            });

            modelBuilder.Entity<PlayerConfig>(entity =>
            {
                entity.HasIndex(e => e.PlayerId)
                    .HasName("IX_PlayerConfig")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BoardType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CardModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplaySn)
                    .HasColumnName("DisplaySN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileTemplateModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerId).HasColumnName("playerId");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimcardSn)
                    .HasColumnName("SIMCardSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermSn)
                    .HasColumnName("TermSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithOne(p => p.PlayerConfig)
                    .HasForeignKey<PlayerConfig>(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayerConfig_Player");
            });

            modelBuilder.Entity<PlayerConfig2>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.DisplaySn)
                    .HasColumnName("DisplaySN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerId).HasColumnName("playerId");

                entity.Property(e => e.PlayerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SimcardSn)
                    .HasColumnName("SIMCardSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sn)
                    .HasColumnName("SN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TermSn)
                    .HasColumnName("TermSN")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerDownload>(entity =>
            {
                entity.HasIndex(e => e.CheckSum);

                entity.HasIndex(e => e.DownloadDetailId)
                    .HasName("IX_PlayerDownload_DownloadID");

                entity.HasIndex(e => e.DownloadTime);

                entity.HasIndex(e => e.PlayerId);

                entity.HasIndex(e => e.Uri)
                    .HasName("IX_PlayerDownload_Uri_Uri");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Data).IsUnicode(false);

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.Retrys).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerDownloadNotify>(entity =>
            {
                entity.HasIndex(e => new { e.PlayerId, e.DownloadDetailId })
                    .HasName("IX_PlayerDownloadNotify");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Data).IsUnicode(false);

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerDownloadPublish>(entity =>
            {
                entity.HasIndex(e => e.DownloadDetailId)
                    .HasName("IX_PlayerDownloadPublish_DownloadId");

                entity.HasIndex(e => e.PlayerId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProcTime).HasColumnType("datetime");

                entity.Property(e => e.Process).HasColumnType("text");

                entity.Property(e => e.RecTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerEvent>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Event)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.RaiseTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerFile>(entity =>
            {
                entity.HasIndex(e => new { e.PlayerId, e.FileId })
                    .HasName("IX_PlayerFile_1")
                    .IsUnique();

                entity.HasIndex(e => new { e.PlayerId, e.IsUpdate })
                    .HasName("IX_PlayerFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTimeSpan).HasColumnType("datetime");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerFile)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayerFileDetail_Player");
            });

            modelBuilder.Entity<PlayerLedconfig>(entity =>
            {
                entity.ToTable("PlayerLEDConfig");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CardModel).HasMaxLength(50);

                entity.Property(e => e.CommunicationMethod).HasMaxLength(50);

                entity.Property(e => e.Dtucenter)
                    .HasColumnName("DTUCenter")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtuid)
                    .HasColumnName("DTUID")
                    .HasMaxLength(50);

                entity.Property(e => e.Dtuport).HasColumnName("DTUPort");

                entity.Property(e => e.GprsserialPortId).HasColumnName("GPRSSerialPortID");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50);

                entity.Property(e => e.Protocol).HasMaxLength(50);

                entity.Property(e => e.SerialPortId).HasColumnName("SerialPortID");

                entity.Property(e => e.SimCard).HasMaxLength(50);

                entity.HasOne(d => d.GprsserialPort)
                    .WithMany(p => p.PlayerLedconfigGprsserialPort)
                    .HasForeignKey(d => d.GprsserialPortId)
                    .HasConstraintName("FK_PLAYERLE_REFERENCE_SERIALPO");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerLedconfig)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_PLAYERLE_REFERENCE_PLAYER");

                entity.HasOne(d => d.SerialPort)
                    .WithMany(p => p.PlayerLedconfigSerialPort)
                    .HasForeignKey(d => d.SerialPortId)
                    .HasConstraintName("FK_PLAYERLE_REFERENCE_SERIALPO2");
            });

            modelBuilder.Entity<PlayerLedfile>(entity =>
            {
                entity.ToTable("PlayerLEDFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTimeSpan).HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerLedfile)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_PlayerLEDFile_Player");
            });

            modelBuilder.Entity<PlayerLedruntimeInfo>(entity =>
            {
                entity.ToTable("PlayerLEDRuntimeInfo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrentProgram).HasMaxLength(50);

                entity.Property(e => e.Font)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.HardwareVersion).HasMaxLength(50);

                entity.Property(e => e.Ledtime)
                    .HasColumnName("LEDTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.SdOk).HasColumnName("SD_OK");

                entity.Property(e => e.SoftwareVersion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerLedruntimeInfo)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_PlayerLEDRuntimeInfo_REFERENCE_PLAYER");
            });

            modelBuilder.Entity<PlayerLinkStts>(entity =>
            {
                entity.HasIndex(e => new { e.PlayerId, e.RecTime })
                    .HasName("IX_PlayerLinkStts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RecTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<PlayerLinkSttsLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RecTime).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<PlayerLog>(entity =>
            {
                entity.HasIndex(e => e.LogTime);

                entity.HasIndex(e => e.PlayerId)
                    .HasName("IX_PlayerLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Exception).IsUnicode(false);

                entity.Property(e => e.LogLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LogTime).HasColumnType("datetime");

                entity.Property(e => e.Logger).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerLog)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayerLog_Player");
            });

            modelBuilder.Entity<PlayerLoginLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerLoginLogBack>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mac)
                    .HasColumnName("MAC")
                    .HasMaxLength(256)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerOperLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OperMemo)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.Remark)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ReqTime).HasColumnType("datetime");

                entity.Property(e => e.RetTime).HasColumnType("datetime");

                entity.Property(e => e.StrData)
                    .HasMaxLength(1024)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerOrgDepartment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrgDepartmentId)
                    .HasColumnName("orgDepartmentId")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerId).HasColumnName("playerId");
            });

            modelBuilder.Entity<PlayerPhone>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.BasicBalance).HasColumnType("money");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.GprsSet).HasMaxLength(50);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PresentBalance).HasMaxLength(50);

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.SimcardSn)
                    .HasColumnName("SIMCardSN")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(10);

                entity.Property(e => e.SurplusFlow).HasMaxLength(50);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerPhone)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_PLAYERPH_REFERENCE_PLAYER");
            });

            modelBuilder.Entity<PlayerPlayListEvent>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("Player_PlayList_Event");

                entity.Property(e => e.PlayerId).ValueGeneratedNever();

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerProgram>(entity =>
            {
                entity.HasIndex(e => new { e.PlayerId, e.IsUpdated })
                    .HasName("IX_PlayerProgram");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.ConfigMd5)
                    .HasColumnName("ConfigMD5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigPath)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.IndexPage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndexPageMd5)
                    .HasColumnName("IndexPageMD5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasColumnName("msg")
                    .IsUnicode(false);

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.PlayerProgram)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayerProgramEvent_Player");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.PlayerProgram)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PlayerProgram_ProgramItem");
            });

            modelBuilder.Entity<PlayerProgramPtss>(entity =>
            {
                entity.ToTable("PlayerProgramPTSS");

                entity.HasIndex(e => e.IsUpdated);

                entity.HasIndex(e => e.PlayerId);

                entity.HasIndex(e => e.ProgramId);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");

                entity.Property(e => e.PtSs).HasColumnName("PT_SS");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerPublish>(entity =>
            {
                entity.HasIndex(e => e.PlayerId);

                entity.HasIndex(e => e.ProcState);

                entity.HasIndex(e => e.ProcesserId);

                entity.HasIndex(e => e.RecTime);

                entity.HasIndex(e => e.Retrys);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcTime).HasColumnType("datetime");

                entity.Property(e => e.ProgramIds)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.RecTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerServer>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.InterfaceId })
                    .HasName("PK_PLAYER_SERVER");

                entity.ToTable("Player_Server");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.InterfaceId)
                    .HasColumnName("InterfaceID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerServerBack>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.InterfaceId })
                    .HasName("PK_Player_Server_back_back");

                entity.ToTable("Player_Server_back");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.InterfaceId)
                    .HasColumnName("InterfaceID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.DownloadTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerStation>(entity =>
            {
                entity.ToTable("Player_Station");

                entity.HasIndex(e => e.PlayId)
                    .HasName("IX_Player_Station")
                    .IsUnique();

                entity.Property(e => e.StaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Play)
                    .WithOne(p => p.PlayerStation)
                    .HasForeignKey<PlayerStation>(d => d.PlayId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Player_Station_Player");
            });

            modelBuilder.Entity<PlayerStatus>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.LoginServer);

                entity.HasIndex(e => e.PlayerId)
                    .IsUnique();

                entity.HasIndex(e => e.Status);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginServer)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerStatusBack>(entity =>
            {
                entity.HasIndex(e => e.PlayerId)
                    .HasName("IX_PlayerStatusBack")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LoginServer)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerStatusHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginServer)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpHistoryTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerStatusHistoryD>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cs).HasColumnName("cs");

                entity.Property(e => e.Lxdays).HasColumnName("lxdays");

                entity.Property(e => e.UDay)
                    .HasColumnName("uDay")
                    .HasColumnType("date");

                entity.Property(e => e.UpHistoryTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<PlayerStatusLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LoginServer)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime).HasColumnType("datetime");

                entity.Property(e => e.LogoutTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerTask>(entity =>
            {
                entity.ToTable("Player_Task");

                entity.HasIndex(e => e.PlayerId);

                entity.HasIndex(e => e.ReqTime);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AnswerTime).HasColumnType("datetime");

                entity.Property(e => e.Counter).HasColumnName("counter");

                entity.Property(e => e.Param)
                    .HasColumnName("param")
                    .IsUnicode(false);

                entity.Property(e => e.ReqTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.TaskType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transfer).HasColumnName("transfer");
            });

            modelBuilder.Entity<PlayerTree>(entity =>
            {
                entity.Property(e => e.DId)
                    .HasColumnName("dID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<PlayerTreeIndex>(entity =>
            {
                entity.HasKey(e => new { e.SubId, e.Parentid });
            });

            modelBuilder.Entity<PlayerUploadFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(4000);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlayerVersion>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PK_PlayerCfgVersion");

                entity.ToTable("Player_Version");

                entity.Property(e => e.PlayerId).ValueGeneratedNever();

                entity.Property(e => e.CheckSum).HasMaxLength(50);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Version).HasMaxLength(50);
            });

            modelBuilder.Entity<ProcessTask>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.HasIndex(e => e.ProcessTime)
                    .HasName("IX_ProcessTask");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.ProcessFinishTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessType).HasMaxLength(50);
            });

            modelBuilder.Entity<ProgramA>(entity =>
            {
                entity.HasKey(e => e.Aid)
                    .HasName("PK_porgram_Y");

                entity.ToTable("program_A");

                entity.Property(e => e.Aid)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Aname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ifdisp).HasColumnName("ifdisp");
            });

            modelBuilder.Entity<ProgramDataTask>(entity =>
            {
                entity.HasKey(e => e.TaskId);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastDownloadTime).HasColumnType("datetime");

                entity.Property(e => e.SavePath)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TaskType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uri)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgramDetail>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Program_Floder")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => new { e.ProgramId, e.FileId })
                    .HasName("IX_ProgramDetail")
                    .IsUnique()
                    .ForSqlServerIsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.ProgramDetail)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProgramDetail_ProgramItem");
            });

            modelBuilder.Entity<ProgramFile>(entity =>
            {
                entity.HasIndex(e => e.FileName)
                    .HasName("IX_ProgramFile")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProgramFileUri>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UpdateUri)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProgramFile)
                    .WithMany(p => p.ProgramFileUri)
                    .HasForeignKey(d => d.ProgramFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProgramFileUri_ProgramFile");
            });

            modelBuilder.Entity<ProgramItem>(entity =>
            {
                entity.HasIndex(e => e.HomeDirectory);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A)
                    .HasColumnName("_A")
                    .HasMaxLength(20);

                entity.Property(e => e.CheckProcessTime1).HasColumnType("datetime");

                entity.Property(e => e.CheckProcessTime2).HasColumnType("datetime");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.Cron)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.DeadTime).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Editmemo)
                    .HasColumnName("editmemo")
                    .HasMaxLength(200);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FitRegion).HasMaxLength(20);

                entity.Property(e => e.HomeDirectory)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InUse)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IndexPage)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Note)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Otherid)
                    .HasColumnName("otherid")
                    .HasMaxLength(50);

                entity.Property(e => e.P)
                    .HasColumnName("_P")
                    .HasMaxLength(20);

                entity.Property(e => e.PlayIntervalSeconds).HasColumnName("playIntervalSeconds");

                entity.Property(e => e.PlayTimeList)
                    .HasColumnName("playTimeList")
                    .HasMaxLength(200);

                entity.Property(e => e.ProcessMsg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.S)
                    .HasColumnName("_S")
                    .HasMaxLength(20);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.T)
                    .HasColumnName("_T")
                    .HasMaxLength(20);

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TreeFl)
                    .HasColumnName("treeFL")
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateSeconds).HasColumnName("updateSeconds");

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");

                entity.Property(e => e.Uri)
                    .HasColumnName("URI")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Views)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.W)
                    .HasColumnName("_W")
                    .HasMaxLength(20);

                entity.HasOne(d => d.PNavigation)
                    .WithMany(p => p.ProgramItem)
                    .HasForeignKey(d => d.P)
                    .HasConstraintName("FK_ProgramItem_Program_P");

                entity.HasOne(d => d.ProgramType)
                    .WithMany(p => p.ProgramItem)
                    .HasForeignKey(d => d.ProgramTypeId)
                    .HasConstraintName("FK_ProgramItem_ProgramType");

                entity.HasOne(d => d.TNavigation)
                    .WithMany(p => p.ProgramItem)
                    .HasForeignKey(d => d.T)
                    .HasConstraintName("FK_ProgramItem_program_T");
            });

            modelBuilder.Entity<ProgramItemSuperComm>(entity =>
            {
                entity.HasKey(e => e.ProgramItemId)
                    .HasName("PK_PROGRAMITEM_SUPERCOMM");

                entity.ToTable("ProgramItem_SuperComm");

                entity.Property(e => e.ProgramItemId)
                    .HasColumnName("ProgramItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Drv).HasMaxLength(50);

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.FileType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.HasOne(d => d.ProgramItem)
                    .WithOne(p => p.ProgramItemSuperComm)
                    .HasForeignKey<ProgramItemSuperComm>(d => d.ProgramItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PROGRAMI_REFERENCE_PROGRAMI");
            });

            modelBuilder.Entity<ProgramLedfile>(entity =>
            {
                entity.ToTable("ProgramLEDFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CheckSum)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.CreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProgramP>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK_Porgram_p");

                entity.ToTable("Program_P");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(50);

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasColumnName("pname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProgramPublish>(entity =>
            {
                entity.HasIndex(e => e.ProcState);

                entity.HasIndex(e => e.RecTime);

                entity.HasIndex(e => e.Retrys);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Msg)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProcTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessId).HasColumnName("ProcessID");

                entity.Property(e => e.RecTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProgramS>(entity =>
            {
                entity.HasKey(e => e.SId)
                    .HasName("PK_program_S_1");

                entity.ToTable("program_S");

                entity.Property(e => e.SId)
                    .HasColumnName("sId")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProgramT>(entity =>
            {
                entity.HasKey(e => e.Tid)
                    .HasName("PK_porgram_T");

                entity.ToTable("program_T");

                entity.Property(e => e.Tid)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Tname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ProgramType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ProgramW>(entity =>
            {
                entity.HasKey(e => e.Wid)
                    .HasName("PK_Porgram_W");

                entity.ToTable("Program_W");

                entity.Property(e => e.Wid)
                    .HasColumnName("wid")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.IsMain)
                    .HasColumnName("isMain")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OffsetX).HasColumnName("offsetX");

                entity.Property(e => e.OffsetY).HasColumnName("offsetY");

                entity.Property(e => e.WindowColor)
                    .HasColumnName("windowColor")
                    .HasMaxLength(50);

                entity.Property(e => e.WindowPid)
                    .HasColumnName("windowPID")
                    .HasMaxLength(20);

                entity.Property(e => e.Wname)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RadorImageFile>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Data).HasColumnType("image");

                entity.Property(e => e.FileCreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RadorImageTask>(entity =>
            {
                entity.HasKey(e => e.FileType);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.PlaySeq)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PlaySeqName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaveFilename)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<RadorImageTaskSaveFile>(entity =>
            {
                entity.HasKey(e => new { e.FileType, e.SeqName })
                    .HasName("PK_RadorImageSaveFile");

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeqName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SaveFileName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecvAlertMsgListEvent>(entity =>
            {
                entity.ToTable("RecvAlertMsgList_Event");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Msg)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MsgCode).HasMaxLength(50);

                entity.Property(e => e.MsgColorCode).HasMaxLength(50);

                entity.Property(e => e.MsgDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MsgTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaSign)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecvWeatherForecast>(entity =>
            {
                entity.Property(e => e.RecvWeatherForecastId).ValueGeneratedNever();

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForeCastMsg).HasColumnType("ntext");

                entity.Property(e => e.ForeCastTime).HasColumnType("datetime");

                entity.Property(e => e.RecvTime).HasColumnType("datetime");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RecvWeatherForecastAdded>(entity =>
            {
                entity.HasKey(e => new { e.StaCode, e.DDate });

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.R).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.RecvContent).HasMaxLength(500);

                entity.Property(e => e.RecvDate).HasColumnType("datetime");

                entity.Property(e => e.S).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.T).HasColumnType("decimal(9, 1)");
            });

            modelBuilder.Entity<RecvWeatherForecastDetail>(entity =>
            {
                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Duration)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ForeCastType)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fs)
                    .IsRequired()
                    .HasColumnName("FS")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Fx)
                    .IsRequired()
                    .HasColumnName("FX")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StaCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.WeatherDesc)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.RecvWeatherForecast)
                    .WithMany(p => p.RecvWeatherForecastDetail)
                    .HasForeignKey(d => d.RecvWeatherForecastId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecvWeatherForecastDetail_RecvWeatherForecast");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Remark)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoleCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.CountryCity)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.CountryCityId)
                    .HasConstraintName("FK_Role_CountryCity");

                entity.HasOne(d => d.RoleType)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.RoleTypeId)
                    .HasConstraintName("FK_Role_RoleType");
            });

            modelBuilder.Entity<RoleCountryCityFilter>(entity =>
            {
                entity.HasKey(e => e.RoleCityId);

                entity.ToTable("Role_CountryCity_filter");

                entity.HasOne(d => d.CountryCity)
                    .WithMany(p => p.RoleCountryCityFilter)
                    .HasForeignKey(d => d.CountryCityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Role_CountryCity_filter_CountryCity");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleCountryCityFilter)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Role_CountryCity_filter_Role");
            });

            modelBuilder.Entity<RolePlayerFilter>(entity =>
            {
                entity.ToTable("Role_Player_filter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.RolePlayerFilter)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("FK_Role_Player_filter_Player");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePlayerFilter)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_Role_Player_filter_Role");
            });

            modelBuilder.Entity<RoleProgramFilter>(entity =>
            {
                entity.ToTable("Role_Program_filter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.RoleProgramFilter)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Role_Program_filter_ProgramItem");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleProgramFilter)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Role_Program_filter_Role");
            });

            modelBuilder.Entity<RoleRightFilter>(entity =>
            {
                entity.HasKey(e => e.RoleRightId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RoleRight_filter");

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RightAdd).HasColumnName("Right_Add");

                entity.Property(e => e.RightDelete).HasColumnName("Right_Delete");

                entity.Property(e => e.RightModify).HasColumnName("Right_Modify");

                entity.Property(e => e.RightPrint).HasColumnName("Right_Print");

                entity.Property(e => e.RightRead).HasColumnName("Right_Read");

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.ControlRights)
                    .WithMany(p => p.RoleRightFilter)
                    .HasForeignKey(d => d.ControlRightsId)
                    .HasConstraintName("FK_RoleRight_filter_ControlRights");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleRightFilter)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleRight_filter_Role");
            });

            modelBuilder.Entity<RoleSpecialRightFilter>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("RoleSpecialRight_filter");
            });

            modelBuilder.Entity<RoleType>(entity =>
            {
                entity.Property(e => e.RoleTypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SerialPortConfig>(entity =>
            {
                entity.HasKey(e => e.SerialPortId)
                    .HasName("PK_SERIALPORTCONFIG");

                entity.Property(e => e.SerialPortId).HasColumnName("SerialPortID");

                entity.Property(e => e.PortType).HasMaxLength(30);
            });

            modelBuilder.Entity<SmsAlertEvent>(entity =>
            {
                entity.HasKey(e => e.AlertEventId)
                    .HasName("PK_SMS_ALERTEVENT");

                entity.ToTable("SMS_AlertEvent");

                entity.Property(e => e.AlertCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.AlertColorCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.StaSign)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.SmsAlertEvent)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_SMS_ALER_FK_SMS_EV_SMS_EVEN");
            });

            modelBuilder.Entity<SmsEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK_SMS_EVENT");

                entity.ToTable("SMS_Event");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.EventName).HasMaxLength(50);

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.SmsContent)
                    .HasColumnName("SMS_Content")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SmsEventRaise>(entity =>
            {
                entity.ToTable("SMS_EventRaise");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.EventName).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.SendContent).HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<SmsLinkUser>(entity =>
            {
                entity.ToTable("SMS_LinkUser");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.SmsLinkUser)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK_SMS_LINK_REFERENCE_SMS_EVEN");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SmsLinkUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SMS_LinkUser_SMS_User");
            });

            modelBuilder.Entity<SmsSend>(entity =>
            {
                entity.ToTable("SMS_Send");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.SendContent).HasMaxLength(255);
            });

            modelBuilder.Entity<SmsUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_SMS_USER");

                entity.ToTable("SMS_User");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.LastDate).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.SmsUser)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_SMS_USER_FK_SMS_US_COUNTRYC");
            });

            modelBuilder.Entity<SpecialControlRight>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RightCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RightDesc)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.RightName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<StationFtp>(entity =>
            {
                entity.ToTable("Station_FTP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileSuffix)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FtpserverId).HasColumnName("FTPServerId");

                entity.Property(e => e.LastFileName).HasMaxLength(50);

                entity.Property(e => e.LastReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.StationId).HasColumnName("StationID");
            });

            modelBuilder.Entity<Stationdata>(entity =>
            {
                entity.HasKey(e => e.StaCode);

                entity.ToTable("STATIONData");

                entity.Property(e => e.StaCode)
                    .HasColumnName("staCode")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LiveType)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stationinfo>(entity =>
            {
                entity.HasKey(e => e.StaCode)
                    .HasName("PK_STATIONINFO_1");

                entity.ToTable("STATIONINFO");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AreaF).HasColumnName("Area_F");

                entity.Property(e => e.AreaS).HasColumnName("Area_S");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DataSorceType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StaType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Town)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCity)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.Stationinfo)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_STATIONINFO_Zone");
            });

            modelBuilder.Entity<SurfGrmcMulHour>(entity =>
            {
                entity.HasKey(e => new { e.StaCode, e.DDate, e.IHour });

                entity.ToTable("SURF_GRMC_MUL_HOUR");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IHour).HasColumnName("iHour");

                entity.Property(e => e.BMax).HasColumnName("B_Max");

                entity.Property(e => e.BMaxTime)
                    .HasColumnName("B_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BMin).HasColumnName("B_Min");

                entity.Property(e => e.BMinTime)
                    .HasColumnName("B_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.C)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DMax).HasColumnName("D_Max");

                entity.Property(e => e.DMaxTime)
                    .HasColumnName("D_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DMin).HasColumnName("D_Min");

                entity.Property(e => e.DMinTime)
                    .HasColumnName("D_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F10s).HasColumnName("F10S");

                entity.Property(e => e.F10x)
                    .HasColumnName("F10X")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2s).HasColumnName("F2S");

                entity.Property(e => e.F2x)
                    .HasColumnName("F2X")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjs).HasColumnName("FJS");

                entity.Property(e => e.Fjtime)
                    .HasColumnName("FJTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjx)
                    .HasColumnName("FJX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fss).HasColumnName("FSS");

                entity.Property(e => e.Fsx)
                    .HasColumnName("FSX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzs).HasColumnName("FZS");

                entity.Property(e => e.Fztime)
                    .HasColumnName("FZTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzx)
                    .HasColumnName("FZX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LB).HasColumnName("L_B");

                entity.Property(e => e.LS).HasColumnName("L_s");

                entity.Property(e => e.Nd).HasColumnName("ND");

                entity.Property(e => e.Nz).HasColumnName("NZ");

                entity.Property(e => e.PMax).HasColumnName("P_Max");

                entity.Property(e => e.PMaxTime)
                    .HasColumnName("P_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PMin).HasColumnName("P_Min");

                entity.Property(e => e.PMinTime)
                    .HasColumnName("P_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RMinute)
                    .HasColumnName("R_Minute")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TMax).HasColumnName("T_Max");

                entity.Property(e => e.TMaxTime)
                    .HasColumnName("T_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TMin).HasColumnName("T_Min");

                entity.Property(e => e.TMinTime)
                    .HasColumnName("T_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UMin).HasColumnName("U_Min");

                entity.Property(e => e.UMinTime)
                    .HasColumnName("U_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VMin).HasColumnName("V_Min");

                entity.Property(e => e.VMinTime)
                    .HasColumnName("V_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.W)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SurfGrmcMulHourNew>(entity =>
            {
                entity.HasKey(e => new { e.StaCode, e.DDate, e.IHour })
                    .HasName("pk_SURF_GRMC_MUL_HOUR_NEW");

                entity.ToTable("SURF_GRMC_MUL_HOUR_NEW");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IHour).HasColumnName("iHour");

                entity.Property(e => e.BMax).HasColumnName("B_Max");

                entity.Property(e => e.BMaxTime)
                    .HasColumnName("B_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.BMin).HasColumnName("B_Min");

                entity.Property(e => e.BMinTime)
                    .HasColumnName("B_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.C)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CollTime).HasColumnType("datetime");

                entity.Property(e => e.DMax).HasColumnName("D_Max");

                entity.Property(e => e.DMaxTime)
                    .HasColumnName("D_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DMin).HasColumnName("D_Min");

                entity.Property(e => e.DMinTime)
                    .HasColumnName("D_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F10s).HasColumnName("F10S");

                entity.Property(e => e.F10x)
                    .HasColumnName("F10X")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2s).HasColumnName("F2S");

                entity.Property(e => e.F2x)
                    .HasColumnName("F2X")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjs).HasColumnName("FJS");

                entity.Property(e => e.Fjtime)
                    .HasColumnName("FJTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjx)
                    .HasColumnName("FJX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fss).HasColumnName("FSS");

                entity.Property(e => e.Fsx)
                    .HasColumnName("FSX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzs).HasColumnName("FZS");

                entity.Property(e => e.FzsH12).HasColumnName("FZS_H12");

                entity.Property(e => e.FzsH6).HasColumnName("FZS_H6");

                entity.Property(e => e.Fztime)
                    .HasColumnName("FZTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzx)
                    .HasColumnName("FZX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FzxH12)
                    .HasColumnName("FZX_H12")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FzxH6)
                    .HasColumnName("FZX_H6")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LB).HasColumnName("L_B");

                entity.Property(e => e.LS).HasColumnName("L_S");

                entity.Property(e => e.Nd).HasColumnName("ND");

                entity.Property(e => e.Nz).HasColumnName("NZ");

                entity.Property(e => e.PMax).HasColumnName("P_Max");

                entity.Property(e => e.PMaxTime)
                    .HasColumnName("P_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PMin).HasColumnName("P_Min");

                entity.Property(e => e.PMinTime)
                    .HasColumnName("P_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.R05).HasColumnName("R_05");

                entity.Property(e => e.R30).HasColumnName("R_30");

                entity.Property(e => e.RH1).HasColumnName("R_H1");

                entity.Property(e => e.RH12).HasColumnName("R_H12");

                entity.Property(e => e.RH2).HasColumnName("R_H2");

                entity.Property(e => e.RH24).HasColumnName("R_H24");

                entity.Property(e => e.RH3).HasColumnName("R_H3");

                entity.Property(e => e.RH6).HasColumnName("R_H6");

                entity.Property(e => e.RMinute)
                    .HasColumnName("R_Minute")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.TMax).HasColumnName("T_Max");

                entity.Property(e => e.TMaxH24).HasColumnName("T_Max_H24");

                entity.Property(e => e.TMaxTime)
                    .HasColumnName("T_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TMin).HasColumnName("T_Min");

                entity.Property(e => e.TMinH24).HasColumnName("T_Min_H24");

                entity.Property(e => e.TMinTime)
                    .HasColumnName("T_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UMax).HasColumnName("U_Max");

                entity.Property(e => e.UMaxTime)
                    .HasColumnName("U_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UMin).HasColumnName("U_Min");

                entity.Property(e => e.UMinTime)
                    .HasColumnName("U_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VMin).HasColumnName("V_Min");

                entity.Property(e => e.VMinTime)
                    .HasColumnName("V_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.W)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysOptLog>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("SysOpt_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Ipaddress)
                    .IsRequired()
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Summary)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TTcObs>(entity =>
            {
                entity.HasKey(e => e.Obsid);

                entity.ToTable("T_TC_OBS");

                entity.Property(e => e.Obsid)
                    .HasColumnName("obsid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ddatetime)
                    .HasColumnName("DDATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Direction).HasColumnName("DIRECTION");

                entity.Property(e => e.Fcid).HasColumnName("FCID");

                entity.Property(e => e.Gust).HasColumnName("GUST");

                entity.Property(e => e.Latitude).HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");

                entity.Property(e => e.Pressure).HasColumnName("PRESSURE");

                entity.Property(e => e.Rr06).HasColumnName("RR06");

                entity.Property(e => e.Rr07).HasColumnName("RR07");

                entity.Property(e => e.Rr08).HasColumnName("RR08");

                entity.Property(e => e.Rr10).HasColumnName("RR10");

                entity.Property(e => e.Rr12).HasColumnName("RR12");

                entity.Property(e => e.Speed).HasColumnName("SPEED");

                entity.Property(e => e.Tcid).HasColumnName("TCID");

                entity.Property(e => e.Tcrank).HasColumnName("TCRANK");

                entity.Property(e => e.Tsid).HasColumnName("TSID");

                entity.Property(e => e.Windspeed).HasColumnName("WINDSPEED");
            });

            modelBuilder.Entity<TTcObsForecase>(entity =>
            {
                entity.HasKey(e => e.Forecaseid);

                entity.ToTable("T_TC_OBS_forecase");

                entity.Property(e => e.Forecaseid)
                    .HasColumnName("forecaseid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ddatetime)
                    .HasColumnName("DDATETIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Direction).HasColumnName("DIRECTION");

                entity.Property(e => e.Fcid).HasColumnName("FCID");

                entity.Property(e => e.Gust).HasColumnName("GUST");

                entity.Property(e => e.Hourtype).HasColumnName("hourtype");

                entity.Property(e => e.Latitude).HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");

                entity.Property(e => e.Obsid).HasColumnName("obsid");

                entity.Property(e => e.Pressure).HasColumnName("PRESSURE");

                entity.Property(e => e.Rr06).HasColumnName("RR06");

                entity.Property(e => e.Rr07).HasColumnName("RR07");

                entity.Property(e => e.Rr08).HasColumnName("RR08");

                entity.Property(e => e.Rr10).HasColumnName("RR10");

                entity.Property(e => e.Rr12).HasColumnName("RR12");

                entity.Property(e => e.Speed).HasColumnName("SPEED");

                entity.Property(e => e.Tcid).HasColumnName("TCID");

                entity.Property(e => e.Tcrank).HasColumnName("TCRANK");

                entity.Property(e => e.Tsid).HasColumnName("TSID");

                entity.Property(e => e.Windspeed).HasColumnName("WINDSPEED");
            });

            modelBuilder.Entity<TTcinfo>(entity =>
            {
                entity.HasKey(e => e.Tsid);

                entity.ToTable("T_TCINFO");

                entity.Property(e => e.Tsid).HasColumnName("TSID");

                entity.Property(e => e.Endtime)
                    .HasColumnName("ENDTIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ifgdfq)
                    .HasColumnName("ifgdfq")
                    .HasMaxLength(1);

                entity.Property(e => e.Intid).HasColumnName("INTID");

                entity.Property(e => e.Intlid).HasColumnName("INTLID");

                entity.Property(e => e.Landon).HasColumnName("LANDON");

                entity.Property(e => e.Landonid)
                    .HasColumnName("landonid")
                    .HasMaxLength(10);

                entity.Property(e => e.Meanings).HasColumnName("MEANINGS");

                entity.Property(e => e.Origin).HasColumnName("ORIGIN");

                entity.Property(e => e.Pathtrend)
                    .HasColumnName("pathtrend")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark).HasColumnName("REMARK");

                entity.Property(e => e.Starttime)
                    .HasColumnName("STARTTIME")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(CONVERT([char](20),getdate(),(120)))");

                entity.Property(e => e.Tscname).HasColumnName("TSCNAME");

                entity.Property(e => e.Tsename).HasColumnName("TSENAME");
            });

            modelBuilder.Entity<TaskClientState>(entity =>
            {
                entity.ToTable("Task_ClientState");

                entity.HasIndex(e => e.ClientName)
                    .HasName("uidx_task_clientstate_clientname")
                    .IsUnique();

                entity.HasIndex(e => e.Id)
                    .HasName("idx_task_clientstate_id");

                entity.HasIndex(e => e.IsChanged)
                    .HasName("idx_task_clientstate_ischanged");

                entity.HasIndex(e => e.IsOnline)
                    .HasName("idx_task_clientstate_isonline");

                entity.HasIndex(e => e.LatestCheckTime)
                    .HasName("idx_task_clientstate_latestchecktime");

                entity.HasIndex(e => e.PlayerId)
                    .HasName("idx_task_clientstate_playerid");

                entity.HasIndex(e => e.ProcessServerName)
                    .HasName("idx_task_clientstate_processservername");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasColumnName("clientName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsChanged).HasColumnName("isChanged");

                entity.Property(e => e.IsOnline).HasColumnName("isOnline");

                entity.Property(e => e.LatestCheckTime)
                    .HasColumnName("latestCheckTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlayerId).HasColumnName("playerId");

                entity.Property(e => e.ProcessServerName)
                    .IsRequired()
                    .HasColumnName("processServerName")
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaskQue>(entity =>
            {
                entity.HasIndex(e => e.ClientName)
                    .HasName("idx_taskque_clientname");

                entity.HasIndex(e => e.Id)
                    .HasName("idx_taskque_id");

                entity.HasIndex(e => e.IsProcessing)
                    .HasName("idx_taskque_isprocessing");

                entity.HasIndex(e => e.MaxRetry)
                    .HasName("idx_taskque_maxretry");

                entity.HasIndex(e => e.PlayerId)
                    .HasName("idx_taskque_playerid");

                entity.HasIndex(e => e.ProcessTime)
                    .HasName("idx_taskque_processtime");

                entity.HasIndex(e => e.RecTime)
                    .HasName("idx_taskque_rectime");

                entity.HasIndex(e => e.ResponeCode)
                    .HasName("idx_taskque_responecode");

                entity.HasIndex(e => e.RetryCount)
                    .HasName("idx_taskque_retrycount");

                entity.Property(e => e.ClientName)
                    .HasColumnName("clientName")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Params)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PlayerId).HasColumnName("playerId");

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.RecTime).HasColumnType("datetime");

                entity.Property(e => e.ResponeMsg)
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(8000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TempRadorImageFile>(entity =>
            {
                entity.Property(e => e.AddTime).HasColumnType("datetime");

                entity.Property(e => e.Data).HasColumnType("image");

                entity.Property(e => e.FileCreateTime).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Template>(entity =>
            {
                entity.Property(e => e.TemplateId)
                    .HasColumnName("TemplateID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Note).HasMaxLength(512);

                entity.Property(e => e.TemplateFileName).HasMaxLength(256);
            });

            modelBuilder.Entity<TemplateParams>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_TEMPLATEPARAMS");

                entity.Property(e => e.TemplateId)
                    .HasColumnName("TemplateID")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Note).HasMaxLength(256);

                entity.Property(e => e.ParamType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Template)
                    .WithOne(p => p.TemplateParams)
                    .HasForeignKey<TemplateParams>(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPParams_REFERENCE_TEMPLATE");
            });

            modelBuilder.Entity<TemplateProgram>(entity =>
            {
                entity.HasKey(e => e.ProgramId)
                    .HasName("PK_TEMPLATEPROGRAM");

                entity.Property(e => e.ProgramId)
                    .HasColumnName("ProgramID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TemplateId)
                    .IsRequired()
                    .HasColumnName("TemplateID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.Program)
                    .WithOne(p => p.TemplateProgram)
                    .HasForeignKey<TemplateProgram>(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TEMPLATE_REFERENCE_PROGRAMI");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.TemplateProgram)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TPProgram_REFERENCE_TEMPLATE");
            });

            modelBuilder.Entity<TemplateProgramItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.DownloadId).HasColumnName("DownloadID");

                entity.Property(e => e.StaCode)
                    .HasColumnName("staCode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.TemplateProgramItem)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_TemplateProgramItem_ProgramItem");
            });

            modelBuilder.Entity<TemplateStyle>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DownloadId).HasColumnName("DownloadID");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.P)
                    .HasColumnName("_P")
                    .HasMaxLength(20);

                entity.Property(e => e.T)
                    .HasColumnName("_T")
                    .HasMaxLength(20);

                entity.Property(e => e.TemplateContent).HasColumnType("text");

                entity.Property(e => e.TemplateName).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(500);

                entity.Property(e => e.W)
                    .HasColumnName("_W")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Test1>(entity =>
            {
                entity.ToTable("test1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdType).HasColumnName("idType");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.StaCode)
                    .HasColumnName("staCode")
                    .HasMaxLength(50);

                entity.Property(e => e.StaName)
                    .HasColumnName("staName")
                    .HasMaxLength(50);

                entity.Property(e => e.VersionStamp)
                    .HasColumnName("versionStamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<TestTable1>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomName).HasMaxLength(50);

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");
            });

            modelBuilder.Entity<TownsInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TownCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TownName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtsProgramItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.IsBg).HasColumnName("isBG");

                entity.Property(e => e.Mp3bg)
                    .HasColumnName("MP3BG")
                    .HasMaxLength(50);

                entity.Property(e => e.PlayInfo)
                    .HasColumnName("playInfo")
                    .HasMaxLength(1000);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.TtsProgramItem)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_TtsProgramItem_ProgramItem");
            });

            modelBuilder.Entity<Tvconfig>(entity =>
            {
                entity.ToTable("TVConfig");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClosePower)
                    .HasColumnName("closePower")
                    .HasMaxLength(50);

                entity.Property(e => e.Model)
                    .HasColumnName("model")
                    .HasMaxLength(50);

                entity.Property(e => e.OpenPower)
                    .HasColumnName("openPower")
                    .HasMaxLength(50);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<UserDefineProgram>(entity =>
            {
                entity.HasIndex(e => e.ProgramId);

                entity.Property(e => e.Content)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.PlayTimeEnd).HasColumnType("datetime");

                entity.Property(e => e.PlayTimeStart).HasColumnType("datetime");

                entity.Property(e => e.PublishTime).HasColumnType("datetime");

                entity.Property(e => e.PublishUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StyleId).HasDefaultValueSql("('')");

                entity.Property(e => e.SubTitle)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VerifyDate).HasColumnType("datetime");

                entity.Property(e => e.VerifyRemark)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CountryCity)
                    .WithMany(p => p.UserDefineProgram)
                    .HasForeignKey(d => d.CountryCityId)
                    .HasConstraintName("FK_UserDefineProgram_CountryCity");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.UserDefineProgram)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_UserDefineProgram_ProgramItem");
            });

            modelBuilder.Entity<UserDefineStyle>(entity =>
            {
                entity.HasKey(e => e.StyleId);

                entity.ToTable("User_Define_Style");

                entity.Property(e => e.Image).HasMaxLength(100);

                entity.Property(e => e.Note).HasMaxLength(400);

                entity.Property(e => e.StyleContent).HasColumnType("ntext");

                entity.Property(e => e.StyleInfo).HasMaxLength(100);

                entity.Property(e => e.StyleName).HasMaxLength(100);

                entity.Property(e => e.Wid)
                    .HasColumnName("wid")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<UserIpLogin>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Ip });

                entity.ToTable("User_IP_Login");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserIpLogin)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_IP_Login_UserProfile");
            });

            modelBuilder.Entity<UserLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("User_Log");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LoginTime)
                    .HasColumnName("login_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogoutTime)
                    .HasColumnName("logout_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLog)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_User_Log_UserProfile");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CreateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Psw)
                    .IsRequired()
                    .HasColumnName("PSW")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("smalldatetime");

                entity.Property(e => e.UserCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.ConutryCity)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.ConutryCityId)
                    .HasConstraintName("FK_UserProfile_CountryCity");
            });

            modelBuilder.Entity<UserProgramFilter>(entity =>
            {
                entity.ToTable("User_Program_filter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.UserProgramFilter)
                    .HasForeignKey(d => d.ProgramId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_User_Program_filter_ProgramItem");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProgramFilter)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_User_Program_filter_UserProfile");
            });

            modelBuilder.Entity<UserRoleFilter>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .ForSqlServerIsClustered(false);

                entity.ToTable("UserRole_filter");
            });

            modelBuilder.Entity<UserSet>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSet)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserSet_UserProfile");
            });

            modelBuilder.Entity<VerifyManage>(entity =>
            {
                entity.Property(e => e.SumitDate).HasColumnType("datetime");

                entity.Property(e => e.VerifyContent)
                    .HasMaxLength(600)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyDate).HasColumnType("datetime");

                entity.Property(e => e.VerifyNote)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyStatusId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerifyTypeId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.SumitUserNavigation)
                    .WithMany(p => p.VerifyManageSumitUserNavigation)
                    .HasForeignKey(d => d.SumitUser);

                entity.HasOne(d => d.VerifyStatus)
                    .WithMany(p => p.VerifyManage)
                    .HasForeignKey(d => d.VerifyStatusId)
                    .HasConstraintName("FK_VerifyManage_VerifyManage");

                entity.HasOne(d => d.VerifyType)
                    .WithMany(p => p.VerifyManage)
                    .HasForeignKey(d => d.VerifyTypeId)
                    .HasConstraintName("FK_VerifyManage_VerifyType");

                entity.HasOne(d => d.VerifyUserNavigation)
                    .WithMany(p => p.VerifyManageVerifyUserNavigation)
                    .HasForeignKey(d => d.VerifyUser);
            });

            modelBuilder.Entity<VerifyProcess>(entity =>
            {
                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.VerifyNote)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Manage)
                    .WithMany(p => p.VerifyProcess)
                    .HasForeignKey(d => d.ManageId)
                    .HasConstraintName("FK_VerifyProcess_VerifyManage");
            });

            modelBuilder.Entity<VerifyStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.Property(e => e.StatusId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VerifyType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VersionInfo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddDate)
                    .HasColumnName("addDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasColumnName("version")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VideoProgramItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ChangeInfo).HasColumnType("text");

                entity.Property(e => e.FlvSize)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsFlv).HasDefaultValueSql("((1))");

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VideoName).HasMaxLength(50);

                entity.Property(e => e.VideoSize).HasMaxLength(50);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.VideoProgramItem)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_VideoProgramItem_ProgramItem");
            });

            modelBuilder.Entity<VirtualStation>(entity =>
            {
                entity.HasKey(e => e.VirtualStaCode)
                    .HasName("PK_VIRTUALSTATION");

                entity.Property(e => e.VirtualStaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StaCode).HasMaxLength(50);

                entity.Property(e => e.StaSign)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VirtualStaName).HasMaxLength(50);
            });

            modelBuilder.Entity<VoiceProgramItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Path).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.VoiceSize).HasMaxLength(50);

                entity.HasOne(d => d.Program)
                    .WithMany(p => p.VoiceProgramItem)
                    .HasForeignKey(d => d.ProgramId)
                    .HasConstraintName("FK_VoiceProgramItem_ProgramItem");
            });

            modelBuilder.Entity<WeatherComCity>(entity =>
            {
                entity.ToTable("Weather_com_City");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Flag)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrarentId)
                    .HasColumnName("prarentId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaCode)
                    .HasColumnName("staCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeatherComForecast>(entity =>
            {
                entity.HasKey(e => new { e.Cityid, e.DateY, e.Fchh });

                entity.ToTable("weather_com_forecast");

                entity.Property(e => e.Cityid)
                    .HasColumnName("cityid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateY)
                    .HasColumnName("date_y")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fchh).HasColumnName("fchh");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CityEn)
                    .HasColumnName("city_en")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fl1)
                    .HasColumnName("fl1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fl2)
                    .HasColumnName("fl2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fl3)
                    .HasColumnName("fl3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fl4)
                    .HasColumnName("fl4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fl5)
                    .HasColumnName("fl5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fl6)
                    .HasColumnName("fl6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fx1)
                    .HasColumnName("fx1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fx2)
                    .HasColumnName("fx2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img1)
                    .HasColumnName("img1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img10)
                    .HasColumnName("img10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img11)
                    .HasColumnName("img11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img12)
                    .HasColumnName("img12")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img2)
                    .HasColumnName("img2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img3)
                    .HasColumnName("img3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img4)
                    .HasColumnName("img4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img5)
                    .HasColumnName("img5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img6)
                    .HasColumnName("img6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img7)
                    .HasColumnName("img7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img8)
                    .HasColumnName("img8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Img9)
                    .HasColumnName("img9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle1)
                    .HasColumnName("img_title1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle10)
                    .HasColumnName("img_title10")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle11)
                    .HasColumnName("img_title11")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle12)
                    .HasColumnName("img_title12")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle2)
                    .HasColumnName("img_title2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle3)
                    .HasColumnName("img_title3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle4)
                    .HasColumnName("img_title4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle5)
                    .HasColumnName("img_title5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle6)
                    .HasColumnName("img_title6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle7)
                    .HasColumnName("img_title7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle8)
                    .HasColumnName("img_title8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitle9)
                    .HasColumnName("img_title9")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ImgTitleSingle)
                    .HasColumnName("img_title_single")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Index)
                    .HasColumnName("index")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Index48)
                    .HasColumnName("index48")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Index48D)
                    .HasColumnName("index48_d")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Index48Uv)
                    .HasColumnName("index48_uv")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndexCl)
                    .HasColumnName("index_cl")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndexCo)
                    .HasColumnName("index_co")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndexD)
                    .HasColumnName("index_d")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.IndexLs)
                    .HasColumnName("index_ls")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndexTr)
                    .HasColumnName("index_tr")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndexUx)
                    .HasColumnName("index_ux")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndexXc)
                    .HasColumnName("index_xc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St1)
                    .HasColumnName("st1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St2)
                    .HasColumnName("st2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St3)
                    .HasColumnName("st3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St4)
                    .HasColumnName("st4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St5)
                    .HasColumnName("st5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.St6)
                    .HasColumnName("st6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temp1)
                    .HasColumnName("temp1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temp2)
                    .HasColumnName("temp2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temp3)
                    .HasColumnName("temp3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temp4)
                    .HasColumnName("temp4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temp5)
                    .HasColumnName("temp5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Temp6)
                    .HasColumnName("temp6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempF1)
                    .HasColumnName("tempF1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempF2)
                    .HasColumnName("tempF2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempF3)
                    .HasColumnName("tempF3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempF4)
                    .HasColumnName("tempF4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempF5)
                    .HasColumnName("tempF5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TempF6)
                    .HasColumnName("tempF6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weather1)
                    .HasColumnName("weather1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weather2)
                    .HasColumnName("weather2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weather3)
                    .HasColumnName("weather3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weather4)
                    .HasColumnName("weather4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weather5)
                    .HasColumnName("weather5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weather6)
                    .HasColumnName("weather6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Week)
                    .HasColumnName("week")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wind1)
                    .HasColumnName("wind1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wind2)
                    .HasColumnName("wind2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wind3)
                    .HasColumnName("wind3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wind4)
                    .HasColumnName("wind4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wind5)
                    .HasColumnName("wind5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Wind6)
                    .HasColumnName("wind6")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeatherMulDay>(entity =>
            {
                entity.HasKey(e => new { e.StaCode, e.DDate });

                entity.ToTable("Weather_MUL_DAY");

                entity.HasIndex(e => e.DDate)
                    .HasName("IX_Weather_MUL_DAY");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.F10s)
                    .HasColumnName("F10S")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.F2s)
                    .HasColumnName("F2S")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.Fjs)
                    .HasColumnName("FJS")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.Fjtime)
                    .HasColumnName("FJTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.Fjx)
                    .HasColumnName("FJX")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.Fzs)
                    .HasColumnName("FZS")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.Fztime)
                    .HasColumnName("FZTime")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.Fzx)
                    .HasColumnName("FZX")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.P)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.PMax)
                    .HasColumnName("P_Max")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.PMaxTime)
                    .HasColumnName("P_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.PMin)
                    .HasColumnName("P_Min")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.PMinTime)
                    .HasColumnName("P_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.Qc).HasColumnName("QC");

                entity.Property(e => e.R)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.R08)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.R0820)
                    .HasColumnName("R08_20")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.R2008)
                    .HasColumnName("R20_08")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.T)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.T08)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.TMax)
                    .HasColumnName("T_Max")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.TMaxTime)
                    .HasColumnName("T_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.TMin)
                    .HasColumnName("T_Min")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.TMin08)
                    .HasColumnName("T_Min08")
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.TMinTime)
                    .HasColumnName("T_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.Td)
                    .HasColumnType("decimal(9, 1)")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.U).HasDefaultValueSql("((-9999))");

                entity.Property(e => e.UMax)
                    .HasColumnName("U_Max")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.UMaxTime)
                    .HasColumnName("U_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");

                entity.Property(e => e.UMin)
                    .HasColumnName("U_Min")
                    .HasDefaultValueSql("((-9999))");

                entity.Property(e => e.UMinTime)
                    .HasColumnName("U_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('-9999')");
            });

            modelBuilder.Entity<WeatherMulHour>(entity =>
            {
                entity.HasKey(e => new { e.StaCode, e.DDate, e.IHour })
                    .HasName("PK_ZDZ_MUL_HOUR");

                entity.ToTable("Weather_MUL_HOUR");

                entity.HasIndex(e => e.DDate)
                    .HasName("IX_Weather_MUL_HOUR");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.IHour).HasColumnName("iHour");

                entity.Property(e => e.F10s)
                    .HasColumnName("F10S")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.F10x)
                    .HasColumnName("F10X")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.F2s)
                    .HasColumnName("F2S")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.F2x)
                    .HasColumnName("F2X")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjs)
                    .HasColumnName("FJS")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Fjtime)
                    .HasColumnName("FJTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjx)
                    .HasColumnName("FJX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzs)
                    .HasColumnName("FZS")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Fztime)
                    .HasColumnName("FZTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzx)
                    .HasColumnName("FZX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.P).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PMax)
                    .HasColumnName("P_Max")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PMaxTime)
                    .HasColumnName("P_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PMin)
                    .HasColumnName("P_Min")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PMinTime)
                    .HasColumnName("P_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.R).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.T).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TMax)
                    .HasColumnName("T_Max")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TMaxTime)
                    .HasColumnName("T_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TMin)
                    .HasColumnName("T_Min")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TMinTime)
                    .HasColumnName("T_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Td).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.U).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UMax)
                    .HasColumnName("U_Max")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UMaxTime)
                    .HasColumnName("U_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UMin)
                    .HasColumnName("U_Min")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UMinTime)
                    .HasColumnName("U_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeatherMulLatest>(entity =>
            {
                entity.HasKey(e => e.StaCode);

                entity.ToTable("Weather_MUL_Latest");

                entity.Property(e => e.StaCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.DDate)
                    .HasColumnName("dDate")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.F10s)
                    .HasColumnName("F10S")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.F10x)
                    .HasColumnName("F10X")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.F2s)
                    .HasColumnName("F2S")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.F2x)
                    .HasColumnName("F2X")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjs)
                    .HasColumnName("FJS")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Fjtime)
                    .HasColumnName("FJTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fjx)
                    .HasColumnName("FJX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzs)
                    .HasColumnName("FZS")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.Fztime)
                    .HasColumnName("FZTime")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Fzx)
                    .HasColumnName("FZX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.P).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PMax)
                    .HasColumnName("P_Max")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PMaxTime)
                    .HasColumnName("P_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PMin)
                    .HasColumnName("P_Min")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.PMinTime)
                    .HasColumnName("P_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.R).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.T).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TMax)
                    .HasColumnName("T_Max")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TMaxTime)
                    .HasColumnName("T_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TMin)
                    .HasColumnName("T_Min")
                    .HasColumnType("decimal(9, 1)");

                entity.Property(e => e.TMinTime)
                    .HasColumnName("T_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Td).HasColumnType("decimal(9, 1)");

                entity.Property(e => e.UMax).HasColumnName("U_Max");

                entity.Property(e => e.UMaxTime)
                    .HasColumnName("U_Max_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UMin).HasColumnName("U_Min");

                entity.Property(e => e.UMinTime)
                    .HasColumnName("U_Min_Time")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WeatherStation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StaCode)
                    .HasColumnName("staCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StaName)
                    .HasColumnName("staName")
                    .HasMaxLength(10);

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<WebTask>(entity =>
            {
                entity.Property(e => e.LastDownloadTime).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Psw)
                    .HasColumnName("PSW")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TaskType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uri)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebTaskType>(entity =>
            {
                entity.HasKey(e => e.TypeName);

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Note)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Window>(entity =>
            {
                entity.HasIndex(e => e.LayoutId)
                    .HasName("IX_Window_LayoutID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMain).HasDefaultValueSql("((0))");

                entity.Property(e => e.Title)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.X).HasDefaultValueSql("((0))");

                entity.Property(e => e.Y).HasDefaultValueSql("((0))");

                entity.Property(e => e.Z).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Layout)
                    .WithMany(p => p.Window)
                    .HasForeignKey(d => d.LayoutId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Window_Layout");
            });

            modelBuilder.Entity<WindowType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<ZkalertMsg>(entity =>
            {
                entity.ToTable("ZKAlertMsg");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlertArea)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.AlertDlbcontent)
                    .HasColumnName("AlertDLBContent")
                    .HasMaxLength(4000);

                entity.Property(e => e.AlertFile).HasMaxLength(4000);

                entity.Property(e => e.AlertId)
                    .HasColumnName("alertId")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AlertLedcontent)
                    .HasColumnName("AlertLEDContent")
                    .HasMaxLength(4000);

                entity.Property(e => e.AlertLevel)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AlertMode)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.AlertSource)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AlertStatus).HasMaxLength(50);

                entity.Property(e => e.AlertTitle).HasMaxLength(250);

                entity.Property(e => e.AlertType).HasMaxLength(50);

                entity.Property(e => e.AlertUrgent)
                    .HasColumnName("alertUrgent")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayMode).HasColumnName("displayMode");

                entity.Property(e => e.DisplayTime).HasColumnName("displayTime");

                entity.Property(e => e.ExpireBeginTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireEndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireTime)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.IsOld).HasColumnName("isOld");

                entity.Property(e => e.IsZkApi).HasColumnName("isZkApi");

                entity.Property(e => e.OldAlertId)
                    .HasColumnName("oldAlertId")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.XyArea)
                    .HasColumnName("xy_area")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.XyPoint)
                    .HasColumnName("xy_point")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.ZkApiTime).HasColumnType("datetime");

                entity.Property(e => e.ZkalertCode)
                    .HasColumnName("ZKAlertCode")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZkalertMsgApi>(entity =>
            {
                entity.ToTable("ZKAlertMsg_API");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Alerttype)
                    .HasColumnName("ALERTTYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Areacode)
                    .HasColumnName("AREACODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCnname)
                    .HasColumnName("CATEGORY_CNNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cityalias)
                    .HasColumnName("CITYALIAS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contactcode)
                    .HasColumnName("CONTACTCODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.Departmentlevel)
                    .HasColumnName("DEPARTMENTLEVEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentlevelCnname)
                    .HasColumnName("DEPARTMENTLEVEL_CNNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmLevel)
                    .HasColumnName("DM_LEVEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DmType)
                    .HasColumnName("DM_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Indentifier)
                    .HasColumnName("INDENTIFIER")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Publishdate)
                    .HasColumnName("PUBLISHDATE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Sender)
                    .HasColumnName("SENDER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCnname)
                    .HasColumnName("SENDER_CNNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Severity)
                    .HasColumnName("SEVERITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SeverityCnname)
                    .HasColumnName("SEVERITY_CNNAME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stationnum)
                    .HasColumnName("STATIONNUM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZkalertMsgDetail>(entity =>
            {
                entity.HasKey(e => new { e.AlertInfoId, e.PlayerId })
                    .HasName("PK_ZKALERTMSGDETAIL");

                entity.ToTable("ZKAlertMsgDetail");

                entity.HasIndex(e => e.IsReported);

                entity.HasIndex(e => e.IsSuccess);

                entity.Property(e => e.AlertInfoId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TimespanZk)
                    .HasColumnName("Timespan_ZK")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ZkalertMsgProgram>(entity =>
            {
                entity.HasKey(e => e.AlertInfoId)
                    .HasName("PK_ZKALERTMSGPROGRAM");

                entity.ToTable("ZKAlertMsgProgram");

                entity.Property(e => e.AlertInfoId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ProgramId).HasColumnName("ProgramID");
            });

            modelBuilder.Entity<ZkalertMsgStat>(entity =>
            {
                entity.HasKey(e => new { e.AlertInfoId, e.AlertArea })
                    .HasName("PK_ZKALERTMSGSTAT");

                entity.ToTable("ZKAlertMsgStat");

                entity.HasIndex(e => e.IsReported);

                entity.Property(e => e.AlertInfoId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AlertArea)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.AlertMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TimespanZk)
                    .HasColumnName("Timespan_ZK")
                    .IsRowVersion();

                entity.Property(e => e.VendorSysId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZkmsgPlayerJson>(entity =>
            {
                entity.ToTable("ZKMsgPlayerJson");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ExpireBeginTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireEndTime).HasColumnType("datetime");

                entity.Property(e => e.IsNew).HasColumnName("isNew");

                entity.Property(e => e.Json)
                    .HasColumnName("json")
                    .HasColumnType("text");

                entity.Property(e => e.Pid).HasColumnName("pid");
            });

            modelBuilder.Entity<ZkplayerStatusReport>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PK_ZKPLAYERSTATUSREPORT");

                entity.ToTable("ZKPlayerStatusReport");

                entity.Property(e => e.PlayerId)
                    .HasColumnName("PlayerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DeviceId)
                    .HasColumnName("DeviceID")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ReportTime).HasColumnType("datetime");

                entity.Property(e => e.TimespanZk)
                    .HasColumnName("Timespan_ZK")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ZkreceivedMsg>(entity =>
            {
                entity.ToTable("ZKReceivedMsg");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcceptSysId)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.HostUri)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InfoType)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Msg).HasColumnType("ntext");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.SendSysId)
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZktestMsg>(entity =>
            {
                entity.ToTable("ZKTestMsg");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AffixPath)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.AlertArea)
                    .HasColumnName("alertArea")
                    .HasMaxLength(500);

                entity.Property(e => e.AlertFile)
                    .HasColumnName("alertFile")
                    .HasMaxLength(256);

                entity.Property(e => e.AlertId)
                    .HasColumnName("alertId")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AlertLevel)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AlertMode)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.AlertType).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceId)
                    .HasColumnName("deviceId")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayMode).HasColumnName("displayMode");

                entity.Property(e => e.DisplayTime).HasColumnName("displayTime");

                entity.Property(e => e.ExpireBeginTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireEndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireTime)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.InfoContent)
                    .HasColumnName("infoContent")
                    .HasMaxLength(250);

                entity.Property(e => e.InfoTitle).HasMaxLength(250);

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.ReceiveTime).HasColumnType("datetime");

                entity.Property(e => e.RequestId)
                    .HasColumnName("RequestID")
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.SendTime).HasColumnType("datetime");

                entity.Property(e => e.UrgentLevel)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.Property(e => e.ZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ParentZoneId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZoneCity>(entity =>
            {
                entity.HasKey(e => e.ZoneCityId)
                    .ForSqlServerIsClustered(false);

                entity.Property(e => e.CityName).HasMaxLength(50);

                entity.Property(e => e.Stacode)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });
        }
    }
}
