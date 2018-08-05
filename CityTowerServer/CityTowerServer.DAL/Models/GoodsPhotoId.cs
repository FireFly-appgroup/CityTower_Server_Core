using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class GoodsPhotoId
    {
        public int GoodsPhotoId1 { get; set; }
        public string GoodsPhotoPath { get; set; }
        public string GoodsPhotoComments { get; set; }
        public int? GoodsId { get; set; }
        public int? ShopId { get; set; }

        public ShopGoodsList ShopGoodsList { get; set; }
    }
}
