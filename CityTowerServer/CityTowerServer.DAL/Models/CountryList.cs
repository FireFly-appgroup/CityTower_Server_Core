using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CountryList
    {
        public CountryList()
        {
            Announcement = new HashSet<Announcement>();
            Auctioneer = new HashSet<Auctioneer>();
            News = new HashSet<News>();
            Places = new HashSet<Places>();
            Poster = new HashSet<Poster>();
            Shop = new HashSet<Shop>();
            Users = new HashSet<Users>();
        }

        public int CountryId { get; set; }
        public string Country { get; set; }

        public ICollection<Announcement> Announcement { get; set; }
        public ICollection<Auctioneer> Auctioneer { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<Places> Places { get; set; }
        public ICollection<Poster> Poster { get; set; }
        public ICollection<Shop> Shop { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
