using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class OnlineList
    {
        public int Uid { get; set; }
        public int StatusId { get; set; }
        public int UserGuid { get; set; }

        public StatusList Status { get; set; }
        public Users U { get; set; }
    }
}
