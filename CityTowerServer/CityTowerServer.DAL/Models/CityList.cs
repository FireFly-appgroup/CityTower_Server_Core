using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CityList
    {
        public CityList()
        {
            AllChat = new HashSet<AllChat>();
            Announcement = new HashSet<Announcement>();
            Auctioneer = new HashSet<Auctioneer>();
            News = new HashSet<News>();
            Places = new HashSet<Places>();
            Poster = new HashSet<Poster>();
            Shop = new HashSet<Shop>();
            Users = new HashSet<Users>();
        }

        public int CityId { get; set; }
        public string City { get; set; }

        public ICollection<AllChat> AllChat { get; set; }
        public ICollection<Announcement> Announcement { get; set; }
        public ICollection<Auctioneer> Auctioneer { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<Places> Places { get; set; }
        public ICollection<Poster> Poster { get; set; }
        public ICollection<Shop> Shop { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
