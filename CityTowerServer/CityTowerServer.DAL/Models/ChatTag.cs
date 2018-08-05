using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class ChatTag
    {
        public int TagId { get; set; }
        public int AllChatMessId { get; set; }

        public TagList Tag { get; set; }
    }
}
