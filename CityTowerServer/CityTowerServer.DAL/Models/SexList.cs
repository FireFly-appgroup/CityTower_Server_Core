using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class SexList
    {
        public SexList()
        {
            Users = new HashSet<Users>();
        }

        public int SexId { get; set; }
        public string Sex { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
