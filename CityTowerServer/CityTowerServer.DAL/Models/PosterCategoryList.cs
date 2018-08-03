using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class PosterCategoryList
    {
        public PosterCategoryList()
        {
            Poster = new HashSet<Poster>();
        }

        public int PosterCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<Poster> Poster { get; set; }
    }
}
