using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class LikeDislikeList
    {
        public int LikeDislikeId { get; set; }
        public int? LikeDislikeCommentsAnnouncementId { get; set; }
        public int? LikeDislikeAuctioneerId { get; set; }
        public int? LikeDislikeNewsId { get; set; }
        public int? LikeDislikeCommentsNewsId { get; set; }
        public int? LikeDislikePlacesId { get; set; }
        public int? LikeDislikeCommentsPlacesId { get; set; }
        public int? LikeDislikePosterId { get; set; }
        public int? LikeDislikeCommentsPosterId { get; set; }
        public int? LikeDislikeBlogPostId { get; set; }
        public int? LikeDislikeBlogPostCommentsId { get; set; }
        public int? LikeDislikeChatId { get; set; }
        public int? LikeDislikeUserUseId { get; set; }
        public int? LikeDislikeUserId { get; set; }
        public int? LikeDislikeGoodsId { get; set; }
        public int Uid { get; set; }
        public int? LikeDislikeAnnouncementId { get; set; }

        public Users U { get; set; }
    }
}
