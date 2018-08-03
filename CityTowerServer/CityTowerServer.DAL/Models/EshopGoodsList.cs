using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class EshopGoodsList
    {
        public EshopGoodsList()
        {
            GoodsPhotoId = new HashSet<GoodsPhotoId>();
        }

        public string GoodsName { get; set; }
        public string GoodsDescription { get; set; }
        public double? GoodsPrice { get; set; }
        public int GoodsId { get; set; }
        public int? GoodsCategoryId { get; set; }
        public int ShopId { get; set; }

        public GoodsCategoryList GoodsCategory { get; set; }
        public Eshop Shop { get; set; }
        public ICollection<GoodsPhotoId> GoodsPhotoId { get; set; }
    }
}
