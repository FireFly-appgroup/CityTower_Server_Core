using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class PosterTag
    {
        public int TagId { get; set; }
        public int PosterId { get; set; }

        public TagList Tag { get; set; }
    }
}
