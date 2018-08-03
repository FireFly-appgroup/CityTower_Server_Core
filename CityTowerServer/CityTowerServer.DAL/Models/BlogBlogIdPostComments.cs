using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogBlogIdPostComments
    {
        public int BpId { get; set; }
        public int BpcId { get; set; }
        public int Uid { get; set; }
        public DateTime BpcData { get; set; }
        public string BpcBody { get; set; }
        public int? BpcLike { get; set; }
        public int? BpcDislike { get; set; }

        public BlogBlogIdPostTable Bp { get; set; }
    }
}
