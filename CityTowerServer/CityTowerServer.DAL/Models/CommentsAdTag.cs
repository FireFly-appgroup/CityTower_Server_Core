using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsAdTag
    {
        public int TagId { get; set; }
        public int Caid { get; set; }

        public TagList Tag { get; set; }
    }
}
