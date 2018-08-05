using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsNews
    {
        public int ComNewsId { get; set; }
        public int NewsId { get; set; }
        public int Uid { get; set; }
        public DateTime ComNewsDate { get; set; }
        public string ComNewsBody { get; set; }
        public int? ComNewsLike { get; set; }
        public int? ComNewsDislike { get; set; }

        public News News { get; set; }
    }
}
