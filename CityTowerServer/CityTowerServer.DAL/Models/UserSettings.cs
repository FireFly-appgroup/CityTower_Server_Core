using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class UserSettings
    {
        public byte[] UserSettingsGps { get; set; }
        public int? UserSettingsSkinId { get; set; }
        public int? UserSettingsLanguageId { get; set; }
        public int Uid { get; set; }

        public Users U { get; set; }
        public LanguageList UserSettingsLanguage { get; set; }
        public SkinList UserSettingsSkin { get; set; }
    }
}
