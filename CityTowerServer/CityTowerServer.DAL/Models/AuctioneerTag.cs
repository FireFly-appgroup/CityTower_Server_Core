using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AuctioneerTag
    {
        public int TagId { get; set; }
        public int AuctioneerId { get; set; }

        public TagList Tag { get; set; }
    }
}
