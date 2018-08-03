using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class SysMessage
    {
        public int Uid { get; set; }
        public string Message { get; set; }
        public DateTime? MessDate { get; set; }

        public Users U { get; set; }
    }
}
