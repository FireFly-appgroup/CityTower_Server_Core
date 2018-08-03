using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AdTag
    {
        public int TagId { get; set; }
        public int AdId { get; set; }

        public TagList Tag { get; set; }
    }
}
