using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsPoster
    {
        public int ComPosterId { get; set; }
        public int PosterId { get; set; }
        public int Uid { get; set; }
        public DateTime ComPosterDate { get; set; }
        public string ComPosterBody { get; set; }
        public int? ComPosterLike { get; set; }
        public int? ComPosterDislike { get; set; }

        public Poster Poster { get; set; }
    }
}
