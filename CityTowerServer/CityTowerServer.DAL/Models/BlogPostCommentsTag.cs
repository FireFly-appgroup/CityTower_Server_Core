using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogPostCommentsTag
    {
        public int TagId { get; set; }
        public int BpcId { get; set; }
        public int Bid { get; set; }

        public TagList Tag { get; set; }
    }
}
