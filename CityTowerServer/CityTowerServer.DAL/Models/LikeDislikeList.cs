using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class LikeDislikeList
    {
        public int LdId { get; set; }
        public int? CommentsAdAd { get; set; }
        public int? AuctioneerId { get; set; }
        public int? NewsId { get; set; }
        public int? CommentsNewsId { get; set; }
        public int? PlacesId { get; set; }
        public int? CommentsPlacesId { get; set; }
        public int? PosterId { get; set; }
        public int? CommentsPosterId { get; set; }
        public int? BlogPostId { get; set; }
        public int? BlogPostCommentsId { get; set; }
        public int? ChatId { get; set; }
        public int? UserUseId { get; set; }
        public int? UserId { get; set; }
        public int? GoodsId { get; set; }
        public int Uid { get; set; }

        public Users U { get; set; }
    }
}
