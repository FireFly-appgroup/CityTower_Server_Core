using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class GoodsPhotoId
    {
        public int GoodsPhotoId1 { get; set; }
        public string PhotoPath { get; set; }
        public string PhotoComments { get; set; }
        public int? GoodsId { get; set; }
        public int? ShopId { get; set; }

        public EshopGoodsList EshopGoodsList { get; set; }
    }
}
