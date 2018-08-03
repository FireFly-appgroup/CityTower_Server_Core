using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsPoster
    {
        public int Cpid { get; set; }
        public int PosterId { get; set; }
        public int Uid { get; set; }
        public DateTime CpDate { get; set; }
        public string CpBody { get; set; }
        public int? CpLike { get; set; }
        public int? CpDislike { get; set; }

        public Poster Poster { get; set; }
    }
}
