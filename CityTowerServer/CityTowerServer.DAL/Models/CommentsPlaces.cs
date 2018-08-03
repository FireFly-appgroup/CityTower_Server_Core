using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsPlaces
    {
        public int Cplid { get; set; }
        public int PlacesId { get; set; }
        public int Uid { get; set; }
        public DateTime CplDate { get; set; }
        public string CplBody { get; set; }
        public int? CplLike { get; set; }
        public int? CplDislike { get; set; }

        public Places Places { get; set; }
    }
}
