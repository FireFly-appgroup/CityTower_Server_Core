using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AuctioneerHistory
    {
        public int AuctioneerId { get; set; }
        public DateTime AucHistoryDateTime { get; set; }
        public string AucHistoryAction { get; set; }
        public int Uid { get; set; }

        public Auctioneer Auctioneer { get; set; }
    }
}
