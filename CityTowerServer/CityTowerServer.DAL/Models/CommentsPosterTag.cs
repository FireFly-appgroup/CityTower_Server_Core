using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class CommentsPosterTag
    {
        public int TagId { get; set; }
        public int Cpid { get; set; }

        public TagList Tag { get; set; }
    }
}
