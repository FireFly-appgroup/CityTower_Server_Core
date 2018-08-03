using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogList
    {
        public int BlogId { get; set; }
        public string BlogStatus { get; set; }
        public string BlogName { get; set; }
        public string BlogSlogon { get; set; }
        public double? BlogRating { get; set; }
        public int? BlogLike { get; set; }
        public int? BlogDislike { get; set; }
        public int? BlogSubscribersNum { get; set; }
        public int BlogCategoryId { get; set; }

        public BlogCategoryList BlogCategory { get; set; }
        public BlogUserTable BlogUserTable { get; set; }
    }
}
