using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CountryList
    {
        public CountryList()
        {
            Ad = new HashSet<Ad>();
            Auctioneer = new HashSet<Auctioneer>();
            Eshop = new HashSet<Eshop>();
            News = new HashSet<News>();
            Places = new HashSet<Places>();
            Poster = new HashSet<Poster>();
            Users = new HashSet<Users>();
        }

        public int CountryId { get; set; }
        public string Country { get; set; }

        public ICollection<Ad> Ad { get; set; }
        public ICollection<Auctioneer> Auctioneer { get; set; }
        public ICollection<Eshop> Eshop { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<Places> Places { get; set; }
        public ICollection<Poster> Poster { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
