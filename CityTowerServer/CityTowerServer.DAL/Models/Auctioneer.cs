using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class Auctioneer
    {
        public int AuctioneerId { get; set; }
        public string AuctioneerName { get; set; }
        public string AuctioneerComment { get; set; }
        public int AuctioneerStartPrice { get; set; }
        public byte[] AuctioneerDirection { get; set; }
        public double? AuctioneerPriceStep { get; set; }
        public int? AuctioneerPrice { get; set; }
        public int? AuctioneerPriceUid { get; set; }
        public int? AuctioneerRansomPrice { get; set; }
        public DateTime AuctioneerDate { get; set; }
        public DateTime AuctioneerEndDate { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int AuctioneerCategoryId { get; set; }

        public AuctioneerCategoryList AuctioneerCategory { get; set; }
        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public Users U { get; set; }
        public AuctioneerHistory AuctioneerHistory { get; set; }
    }
}
