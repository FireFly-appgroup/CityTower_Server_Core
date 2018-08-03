using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsNews
    {
        public int Cnid { get; set; }
        public int NewsId { get; set; }
        public int Uid { get; set; }
        public DateTime CnDate { get; set; }
        public string CnBody { get; set; }
        public int? CnLike { get; set; }
        public int? CnDislike { get; set; }

        public News News { get; set; }
    }
}
