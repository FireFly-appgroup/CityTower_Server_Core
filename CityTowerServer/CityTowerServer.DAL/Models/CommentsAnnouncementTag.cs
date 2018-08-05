using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsAnnouncementTag
    {
        public int TagId { get; set; }
        public int ComAnnouncementId { get; set; }

        public TagList Tag { get; set; }
    }
}
