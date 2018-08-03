using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class ChatTag
    {
        public int TagId { get; set; }
        public int MessId { get; set; }

        public TagList Tag { get; set; }
    }
}
