using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogPostComments
    {
        public int BlogPostId { get; set; }
        public int BlogPostComId { get; set; }
        public int Uid { get; set; }
        public DateTime BlogPostComData { get; set; }
        public string BlogPostComBody { get; set; }
        public int? BlogPostComLike { get; set; }
        public int? BlogPostComDislike { get; set; }

        public BlogPostTable BlogPost { get; set; }
    }
}
