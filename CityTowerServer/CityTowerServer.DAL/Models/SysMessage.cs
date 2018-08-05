using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class SysMessage
    {
        public int Uid { get; set; }
        public string SysMessage1 { get; set; }
        public DateTime? SysMessageDate { get; set; }

        public Users U { get; set; }
    }
}
