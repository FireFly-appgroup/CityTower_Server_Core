using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class AllChat
    {
        public int AllChatMessId { get; set; }
        public string AllChatMessBody { get; set; }
        public DateTime AllChatMessDate { get; set; }
        public int Uid { get; set; }
        public int CityId { get; set; }
        public int? RoomId { get; set; }

        public CityList City { get; set; }
        public RoomChatId Room { get; set; }
        public Users U { get; set; }
    }
}
