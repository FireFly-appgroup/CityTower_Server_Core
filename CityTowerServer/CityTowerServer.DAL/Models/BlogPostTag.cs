using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogPostTag
    {
        public int TagId { get; set; }
        public int BlogPostId { get; set; }
        public int BlogId { get; set; }

        public TagList Tag { get; set; }
    }
}
