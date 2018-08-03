using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class LanguageList
    {
        public LanguageList()
        {
            UserSettings = new HashSet<UserSettings>();
        }

        public int LanguageId { get; set; }
        public string Language { get; set; }

        public ICollection<UserSettings> UserSettings { get; set; }
    }
}
