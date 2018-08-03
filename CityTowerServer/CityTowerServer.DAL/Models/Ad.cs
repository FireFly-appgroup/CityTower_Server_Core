using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class Ad
    {
        public Ad()
        {
            CommentsAd = new HashSet<CommentsAd>();
        }

        public int AdId { get; set; }
        public string AdTema { get; set; }
        public string AdBody { get; set; }
        public DateTime AdDate { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int AdCategoryId { get; set; }

        public AdCategoryList AdCategory { get; set; }
        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public Users U { get; set; }
        public ICollection<CommentsAd> CommentsAd { get; set; }
    }
}
