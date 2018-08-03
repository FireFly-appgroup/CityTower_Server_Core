using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class News
    {
        public News()
        {
            CommentsNews = new HashSet<CommentsNews>();
        }

        public int NewsId { get; set; }
        public string NewsTeme { get; set; }
        public string NewsBody { get; set; }
        public DateTime NewsDate { get; set; }
        public double? NewsRating { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int NewsCategoryId { get; set; }
        public int? NewsLike { get; set; }
        public int? NewsDislike { get; set; }

        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public NewsCategoryList NewsCategory { get; set; }
        public Users U { get; set; }
        public ICollection<CommentsNews> CommentsNews { get; set; }
    }
}
