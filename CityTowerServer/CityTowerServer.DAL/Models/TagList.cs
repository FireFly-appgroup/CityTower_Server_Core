using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class TagList
    {
        public int TagId { get; set; }
        public string TagName { get; set; }
        public int? AdCount { get; set; }
        public int? CommentsAdCount { get; set; }
        public int? AuctioneerCount { get; set; }
        public int? NewsCount { get; set; }
        public int? CommentsNewsCount { get; set; }
        public int? PlacesCount { get; set; }
        public int? CommentsPlacesCount { get; set; }
        public int? PosterCount { get; set; }
        public int? CommentsPosterCount { get; set; }
        public int? BlogPostCount { get; set; }
        public int? BlogPostCommentsCount { get; set; }
        public int? ChatCount { get; set; }
        public int? UserUseCount { get; set; }
        public int? UserCount { get; set; }
        public int? GoodsCount { get; set; }

        public AdTag AdTag { get; set; }
        public AuctioneerTag AuctioneerTag { get; set; }
        public BlogPostCommentsTag BlogPostCommentsTag { get; set; }
        public BlogPostTag BlogPostTag { get; set; }
        public ChatTag ChatTag { get; set; }
        public CommentsAdTag CommentsAdTag { get; set; }
        public CommentsNewsTag CommentsNewsTag { get; set; }
        public CommentsPlacesTag CommentsPlacesTag { get; set; }
        public CommentsPosterTag CommentsPosterTag { get; set; }
        public GoodsTag GoodsTag { get; set; }
        public NewsTag NewsTag { get; set; }
        public PlacesTag PlacesTag { get; set; }
        public PosterTag PosterTag { get; set; }
        public UserTag UserTag { get; set; }
        public UserUseTag UserUseTag { get; set; }
    }
}
