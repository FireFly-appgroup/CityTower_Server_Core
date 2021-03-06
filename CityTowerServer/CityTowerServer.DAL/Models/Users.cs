﻿using System;
using System.Collections.Generic;

namespace CityTowerServer.DAL.Models
{
    public partial class Users
    {
        public Users()
        {
            AllChat = new HashSet<AllChat>();
            Announcement = new HashSet<Announcement>();
            Auctioneer = new HashSet<Auctioneer>();
            BlogUserTable = new HashSet<BlogUserTable>();
            LikeDislikeList = new HashSet<LikeDislikeList>();
            News = new HashSet<News>();
            Places = new HashSet<Places>();
            Poster = new HashSet<Poster>();
            Shop = new HashSet<Shop>();
        }

        public int Uid { get; set; }
        public byte[] UserPremiumStatus { get; set; }
        public DateTime UserRegDate { get; set; }
        public string UserName { get; set; }
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        public string UserTel { get; set; }
        public string UserNikname { get; set; }
        public DateTime? UserDateOfBirth { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserAvator { get; set; }
        public double? UserRating { get; set; }
        public int? UserLike { get; set; }
        public int? UserDislike { get; set; }
        public string UserPasswordHistory { get; set; }
        public string UserLogFile { get; set; }
        public string UserLocation { get; set; }
        public DateTime? UserLastOnline { get; set; }
        public string UserSlogon { get; set; }
        public int? SexId { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public int? UserBonusCount { get; set; }

        public CityList City { get; set; }
        public CountryList Country { get; set; }
        public SexList Sex { get; set; }
        public OnlineList OnlineList { get; set; }
        public SysMessage SysMessage { get; set; }
        public UserSettings UserSettings { get; set; }
        public ICollection<AllChat> AllChat { get; set; }
        public ICollection<Announcement> Announcement { get; set; }
        public ICollection<Auctioneer> Auctioneer { get; set; }
        public ICollection<BlogUserTable> BlogUserTable { get; set; }
        public ICollection<LikeDislikeList> LikeDislikeList { get; set; }
        public ICollection<News> News { get; set; }
        public ICollection<Places> Places { get; set; }
        public ICollection<Poster> Poster { get; set; }
        public ICollection<Shop> Shop { get; set; }
    }
}
