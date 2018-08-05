using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class RoomChatId
    {
        public RoomChatId()
        {
            AllChat = new HashSet<AllChat>();
        }

        public int RoomId { get; set; }
        public string RoomName { get; set; }

        public ICollection<AllChat> AllChat { get; set; }
    }
}
