using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogCategoryList
    {
        public BlogCategoryList()
        {
            BlogList = new HashSet<BlogList>();
        }

        public int BlogCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<BlogList> BlogList { get; set; }
    }
}
