using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AnnouncementTag
    {
        public int TagId { get; set; }
        public int AnnouncementId { get; set; }

        public TagList Tag { get; set; }
    }
}
