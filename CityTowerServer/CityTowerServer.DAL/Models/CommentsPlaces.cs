using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsPlaces
    {
        public int ComPlasesId { get; set; }
        public int PlacesId { get; set; }
        public int Uid { get; set; }
        public DateTime ComPlasesDate { get; set; }
        public string ComPlasesBody { get; set; }
        public int? ComPlasesLike { get; set; }
        public int? ComPlasesDislike { get; set; }

        public Places Places { get; set; }
    }
}
