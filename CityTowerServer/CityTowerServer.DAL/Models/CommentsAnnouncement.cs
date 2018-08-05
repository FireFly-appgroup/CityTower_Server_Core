using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsAnnouncement
    {
        public int ComAnnouncementId { get; set; }
        public int AnnouncementId { get; set; }
        public int Uid { get; set; }
        public DateTime ComAnnouncementDate { get; set; }
        public string ComAnnouncementBody { get; set; }
        public int? ComAnnouncementLike { get; set; }
        public int? ComAnnouncementDislike { get; set; }

        public Announcement Announcement { get; set; }
    }
}
