using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class PlacesCategoryList
    {
        public PlacesCategoryList()
        {
            Places = new HashSet<Places>();
        }

        public int PlacesCategoryId { get; set; }
        public string Category { get; set; }

        public ICollection<Places> Places { get; set; }
    }
}
