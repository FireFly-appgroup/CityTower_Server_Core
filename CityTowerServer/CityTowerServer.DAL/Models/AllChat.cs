using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AllChat
    {
        public int MessId { get; set; }
        public string MessBody { get; set; }
        public DateTime MessDate { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }

        public CityList City { get; set; }
        public Users U { get; set; }
    }
}
