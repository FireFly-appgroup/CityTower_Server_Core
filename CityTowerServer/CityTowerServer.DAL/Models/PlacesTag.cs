using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class PlacesTag
    {
        public int TagId { get; set; }
        public int PlacesId { get; set; }

        public TagList Tag { get; set; }
    }
}
