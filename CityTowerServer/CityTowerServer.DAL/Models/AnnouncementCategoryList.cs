using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AnnouncementCategoryList
    {
        public AnnouncementCategoryList()
        {
            Announcement = new HashSet<Announcement>();
        }

        public int AnnouncementCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<Announcement> Announcement { get; set; }
    }
}
