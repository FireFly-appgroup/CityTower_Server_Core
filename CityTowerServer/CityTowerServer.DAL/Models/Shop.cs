using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class Shop
    {
        public Shop()
        {
            CommentsEshop = new HashSet<CommentsEshop>();
            ShopGoodsList = new HashSet<ShopGoodsList>();
        }

        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public string ShopComments { get; set; }
        public string ShopSlogon { get; set; }
        public double? ShopRating { get; set; }
        public int? ShopLike { get; set; }
        public int? ShopDislike { get; set; }
        public DateTime ShopRegDate { get; set; }
        public int? Uid { get; set; }
        public int? CityId { get; set; }
        public int? CountryId { get; set; }

        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public Users U { get; set; }
        public ICollection<CommentsEshop> CommentsEshop { get; set; }
        public ICollection<ShopGoodsList> ShopGoodsList { get; set; }
    }
}
