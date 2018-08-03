using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsPlacesTag
    {
        public int TagId { get; set; }
        public int Cplid { get; set; }

        public TagList Tag { get; set; }
    }
}
