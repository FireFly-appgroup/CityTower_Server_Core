using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AuctioneerHistory
    {
        public int AuctioneerId { get; set; }
        public DateTime DateTime { get; set; }
        public string Act { get; set; }
        public int Uid { get; set; }

        public Auctioneer Auctioneer { get; set; }
    }
}
