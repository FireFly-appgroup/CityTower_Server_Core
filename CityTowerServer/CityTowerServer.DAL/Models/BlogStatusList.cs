using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogStatusList
    {
        public BlogStatusList()
        {
            BlogUserTable = new HashSet<BlogUserTable>();
        }

        public int BlogStatusId { get; set; }
        public string Status { get; set; }

        public ICollection<BlogUserTable> BlogUserTable { get; set; }
    }
}
