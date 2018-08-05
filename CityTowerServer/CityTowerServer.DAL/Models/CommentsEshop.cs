using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsEshop
    {
        public int CommentsEshopId { get; set; }
        public int? Uid { get; set; }
        public DateTime? CommentsEshopDate { get; set; }
        public string CommentsEshopBody { get; set; }
        public int? CommentsEshopLike { get; set; }
        public int? CommentsEshopDislike { get; set; }
        public int ShopId { get; set; }

        public Shop Shop { get; set; }
    }
}
