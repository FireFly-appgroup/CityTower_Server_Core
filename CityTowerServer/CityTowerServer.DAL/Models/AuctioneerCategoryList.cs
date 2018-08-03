using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AuctioneerCategoryList
    {
        public AuctioneerCategoryList()
        {
            Auctioneer = new HashSet<Auctioneer>();
        }

        public int AuctioneerCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<Auctioneer> Auctioneer { get; set; }
    }
}
