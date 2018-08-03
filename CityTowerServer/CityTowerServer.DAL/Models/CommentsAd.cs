using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsAd
    {
        public int Caid { get; set; }
        public int AdId { get; set; }
        public int Uid { get; set; }
        public DateTime CaDate { get; set; }
        public string CaBody { get; set; }
        public int? CaLike { get; set; }
        public int? CaDislike { get; set; }

        public Ad Ad { get; set; }
    }
}
