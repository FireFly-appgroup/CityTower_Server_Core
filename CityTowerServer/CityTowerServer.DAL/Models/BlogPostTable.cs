using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogPostTable
    {
        public BlogPostTable()
        {
            BlogPostComments = new HashSet<BlogPostComments>();
        }

        public int BlogPostId { get; set; }
        public string BlogPostTema { get; set; }
        public string BlogPostBody { get; set; }
        public DateTime BlogPostData { get; set; }
        public double? BlogPostRating { get; set; }
        public int? BlogPostLike { get; set; }
        public int? BlogPostDislike { get; set; }

        public ICollection<BlogPostComments> BlogPostComments { get; set; }
    }
}
