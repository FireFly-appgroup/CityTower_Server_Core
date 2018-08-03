using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AdCategoryList
    {
        public AdCategoryList()
        {
            Ad = new HashSet<Ad>();
        }

        public int AdCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<Ad> Ad { get; set; }
    }
}
