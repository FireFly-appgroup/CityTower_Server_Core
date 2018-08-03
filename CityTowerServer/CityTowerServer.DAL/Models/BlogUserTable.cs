using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class BlogUserTable
    {
        public int BlogId { get; set; }
        public int Uid { get; set; }
        public int BlogStatusId { get; set; }

        public BlogList Blog { get; set; }
        public BlogStatusList BlogStatus { get; set; }
        public Users U { get; set; }
    }
}
