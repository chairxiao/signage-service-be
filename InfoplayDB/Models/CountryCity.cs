using System;
using System.Collections.Generic;

namespace InfoplayDB.Models
{
    public partial class CountryCity
    {
        public CountryCity()
        {
            CountryCityPlayer = new HashSet<CountryCityPlayer>();
            CountryCityProgram = new HashSet<CountryCityProgram>();
            IpLogin = new HashSet<IpLogin>();
            Player = new HashSet<Player>();
            Role = new HashSet<Role>();
            RoleCountryCityFilter = new HashSet<RoleCountryCityFilter>();
            SmsUser = new HashSet<SmsUser>();
            UserDefineProgram = new HashSet<UserDefineProgram>();
            UserProfile = new HashSet<UserProfile>();
        }

        public int CountryCityId { get; set; }
        public string CountryName { get; set; }
        public int? ZoneCityId { get; set; }
        public string StaCode { get; set; }
        public string StaSign { get; set; }
        public double? Longtitude { get; set; }
        public double? Latitude { get; set; }
        public double? CityZoomlevel { get; set; }
        public bool? Flag { get; set; }
        public int? AddBy { get; set; }
        public DateTime? AddDate { get; set; }
        public int? LastBy { get; set; }
        public DateTime? LastDate { get; set; }

        public virtual Stationinfo StaCodeNavigation { get; set; }
        public virtual ZoneCity ZoneCity { get; set; }
        public virtual ICollection<CountryCityPlayer> CountryCityPlayer { get; set; }
        public virtual ICollection<CountryCityProgram> CountryCityProgram { get; set; }
        public virtual ICollection<IpLogin> IpLogin { get; set; }
        public virtual ICollection<Player> Player { get; set; }
        public virtual ICollection<Role> Role { get; set; }
        public virtual ICollection<RoleCountryCityFilter> RoleCountryCityFilter { get; set; }
        public virtual ICollection<SmsUser> SmsUser { get; set; }
        public virtual ICollection<UserDefineProgram> UserDefineProgram { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
    }
}
