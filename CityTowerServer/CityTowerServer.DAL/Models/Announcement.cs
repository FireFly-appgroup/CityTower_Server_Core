using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class Announcement
    {
        public Announcement()
        {
            CommentsAnnouncement = new HashSet<CommentsAnnouncement>();
        }

        public int AnnouncementId { get; set; }
        public string AnnouncementTema { get; set; }
        public string AnnouncementBody { get; set; }
        public DateTime AnnouncementDate { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int AnnouncementCategoryId { get; set; }
        public int? AnnouncementLike { get; set; }
        public int? AnnouncementDislike { get; set; }
        public int? AnnouncementRating { get; set; }

        public AnnouncementCategoryList AnnouncementCategory { get; set; }
        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public Users U { get; set; }
        public ICollection<CommentsAnnouncement> CommentsAnnouncement { get; set; }
    }
}
