using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class StatusList
    {
        public StatusList()
        {
            OnlineList = new HashSet<OnlineList>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }

        public ICollection<OnlineList> OnlineList { get; set; }
    }
}
