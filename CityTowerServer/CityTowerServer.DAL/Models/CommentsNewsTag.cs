using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsNewsTag
    {
        public int TagId { get; set; }
        public int ComNewsId { get; set; }

        public TagList Tag { get; set; }
    }
}
