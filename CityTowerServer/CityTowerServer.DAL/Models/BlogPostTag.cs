using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogPostTag
    {
        public int TagId { get; set; }
        public int BpId { get; set; }
        public int Bid { get; set; }

        public TagList Tag { get; set; }
    }
}
