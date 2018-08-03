using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsEshop
    {
        public int CesId { get; set; }
        public int? Uid { get; set; }
        public DateTime? CesDate { get; set; }
        public string CesBody { get; set; }
        public int? CesLike { get; set; }
        public int? CesDislike { get; set; }
        public int ShopId { get; set; }

        public Eshop Shop { get; set; }
    }
}
