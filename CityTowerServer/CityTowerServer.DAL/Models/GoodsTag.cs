using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class GoodsTag
    {
        public int GoodsId { get; set; }
        public int TagId { get; set; }

        public TagList Tag { get; set; }
    }
}
