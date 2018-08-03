using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class UserSettings
    {
        public byte[] UserGpsLoc { get; set; }
        public int? SkinId { get; set; }
        public int? LanguageId { get; set; }
        public int Uid { get; set; }

        public LanguageList Language { get; set; }
        public SkinList Skin { get; set; }
        public Users U { get; set; }
    }
}
