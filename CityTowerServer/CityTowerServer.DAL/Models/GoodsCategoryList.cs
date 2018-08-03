using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class GoodsCategoryList
    {
        public GoodsCategoryList()
        {
            EshopGoodsList = new HashSet<EshopGoodsList>();
        }

        public int GoodsCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<EshopGoodsList> EshopGoodsList { get; set; }
    }
}
