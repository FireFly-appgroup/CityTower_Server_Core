using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class SkinList
    {
        public SkinList()
        {
            UserSettings = new HashSet<UserSettings>();
        }

        public int SkinId { get; set; }
        public string SkinName { get; set; }

        public ICollection<UserSettings> UserSettings { get; set; }
    }
}
