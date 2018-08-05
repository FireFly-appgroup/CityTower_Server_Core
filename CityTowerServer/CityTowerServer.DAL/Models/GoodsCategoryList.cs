using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class GoodsCategoryList
    {
        public GoodsCategoryList()
        {
            ShopGoodsList = new HashSet<ShopGoodsList>();
        }

        public int GoodsCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<ShopGoodsList> ShopGoodsList { get; set; }
    }
}
