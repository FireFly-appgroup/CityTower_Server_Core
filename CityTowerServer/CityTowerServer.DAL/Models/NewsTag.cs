using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class NewsTag
    {
        public int TagId { get; set; }
        public int NewsId { get; set; }

        public TagList Tag { get; set; }
    }
}
