using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogBlogIdPostTable
    {
        public BlogBlogIdPostTable()
        {
            BlogBlogIdPostComments = new HashSet<BlogBlogIdPostComments>();
        }

        public int BpId { get; set; }
        public string BlogPostTema { get; set; }
        public string BlogPostBody { get; set; }
        public DateTime BlogPostData { get; set; }
        public double? BlogPostRating { get; set; }
        public int? BlogPostLike { get; set; }
        public int? BlogPostDislike { get; set; }

        public ICollection<BlogBlogIdPostComments> BlogBlogIdPostComments { get; set; }
    }
}
