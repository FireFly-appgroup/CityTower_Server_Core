using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogPostCommentsTag
    {
        public int TagId { get; set; }
        public int BlogPostComId { get; set; }
        public int BlogId { get; set; }

        public TagList Tag { get; set; }
    }
}
