using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class Poster
    {
        public Poster()
        {
            CommentsPoster = new HashSet<CommentsPoster>();
        }

        public int PosterId { get; set; }
        public string PosterTema { get; set; }
        public string PosterBody { get; set; }
        public DateTime PosterDate { get; set; }
        public DateTime PosterStartDate { get; set; }
        public double? PosterRating { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int PosterCategoryId { get; set; }
        public int? PosterLike { get; set; }
        public int? PosterDislike { get; set; }

        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public PosterCategoryList PosterCategory { get; set; }
        public Users U { get; set; }
        public ICollection<CommentsPoster> CommentsPoster { get; set; }
    }
}
