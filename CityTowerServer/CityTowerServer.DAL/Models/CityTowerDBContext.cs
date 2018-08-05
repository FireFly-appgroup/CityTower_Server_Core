using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CityTowerServer.DAL.Models
{
    public partial class CityTowerDBContext : DbContext
    {
        public CityTowerDBContext()
        {
        }

        public CityTowerDBContext(DbContextOptions<CityTowerDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllChat> AllChat { get; set; }
        public virtual DbSet<Announcement> Announcement { get; set; }
        public virtual DbSet<AnnouncementCategoryList> AnnouncementCategoryList { get; set; }
        public virtual DbSet<AnnouncementTag> AnnouncementTag { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Auctioneer> Auctioneer { get; set; }
        public virtual DbSet<AuctioneerCategoryList> AuctioneerCategoryList { get; set; }
        public virtual DbSet<AuctioneerHistory> AuctioneerHistory { get; set; }
        public virtual DbSet<AuctioneerTag> AuctioneerTag { get; set; }
        public virtual DbSet<BlogCategoryList> BlogCategoryList { get; set; }
        public virtual DbSet<BlogList> BlogList { get; set; }
        public virtual DbSet<BlogPostComments> BlogPostComments { get; set; }
        public virtual DbSet<BlogPostCommentsTag> BlogPostCommentsTag { get; set; }
        public virtual DbSet<BlogPostTable> BlogPostTable { get; set; }
        public virtual DbSet<BlogPostTag> BlogPostTag { get; set; }
        public virtual DbSet<BlogStatusList> BlogStatusList { get; set; }
        public virtual DbSet<BlogUserTable> BlogUserTable { get; set; }
        public virtual DbSet<ChatTag> ChatTag { get; set; }
        public virtual DbSet<CityList> CityList { get; set; }
        public virtual DbSet<CommentsAnnouncement> CommentsAnnouncement { get; set; }
        public virtual DbSet<CommentsAnnouncementTag> CommentsAnnouncementTag { get; set; }
        public virtual DbSet<CommentsEshop> CommentsEshop { get; set; }
        public virtual DbSet<CommentsNews> CommentsNews { get; set; }
        public virtual DbSet<CommentsNewsTag> CommentsNewsTag { get; set; }
        public virtual DbSet<CommentsPlaces> CommentsPlaces { get; set; }
        public virtual DbSet<CommentsPlacesTag> CommentsPlacesTag { get; set; }
        public virtual DbSet<CommentsPoster> CommentsPoster { get; set; }
        public virtual DbSet<CommentsPosterTag> CommentsPosterTag { get; set; }
        public virtual DbSet<CountryList> CountryList { get; set; }
        public virtual DbSet<GoodsCategoryList> GoodsCategoryList { get; set; }
        public virtual DbSet<GoodsPhotoId> GoodsPhotoId { get; set; }
        public virtual DbSet<GoodsTag> GoodsTag { get; set; }
        public virtual DbSet<LanguageList> LanguageList { get; set; }
        public virtual DbSet<LikeDislikeList> LikeDislikeList { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistory { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsCategoryList> NewsCategoryList { get; set; }
        public virtual DbSet<NewsTag> NewsTag { get; set; }
        public virtual DbSet<OnlineList> OnlineList { get; set; }
        public virtual DbSet<Places> Places { get; set; }
        public virtual DbSet<PlacesCategoryList> PlacesCategoryList { get; set; }
        public virtual DbSet<PlacesTag> PlacesTag { get; set; }
        public virtual DbSet<Poster> Poster { get; set; }
        public virtual DbSet<PosterCategoryList> PosterCategoryList { get; set; }
        public virtual DbSet<PosterTag> PosterTag { get; set; }
        public virtual DbSet<RoomChatId> RoomChatId { get; set; }
        public virtual DbSet<SexList> SexList { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<ShopGoodsList> ShopGoodsList { get; set; }
        public virtual DbSet<SkinList> SkinList { get; set; }
        public virtual DbSet<StatusList> StatusList { get; set; }
        public virtual DbSet<SysMessage> SysMessage { get; set; }
        public virtual DbSet<TagList> TagList { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<UserTag> UserTag { get; set; }
        public virtual DbSet<UserUseTag> UserUseTag { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=CityTowerDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllChat>(entity =>
            {
                entity.HasKey(e => e.AllChatMessId);

                entity.ToTable("All_chat");

                entity.Property(e => e.AllChatMessId)
                    .HasColumnName("All_chat_mess_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllChatMessBody)
                    .IsRequired()
                    .HasColumnName("All_chat_mess_body")
                    .HasMaxLength(300);

                entity.Property(e => e.AllChatMessDate)
                    .HasColumnName("All_chat_mess_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.RoomId).HasColumnName("Room_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AllChat)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_156");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.AllChat)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("R_73");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.AllChat)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_132");
            });

            modelBuilder.Entity<Announcement>(entity =>
            {
                entity.Property(e => e.AnnouncementId)
                    .HasColumnName("Announcement_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnnouncementBody)
                    .IsRequired()
                    .HasColumnName("Announcement_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.AnnouncementCategoryId).HasColumnName("Announcement_category_id");

                entity.Property(e => e.AnnouncementDate)
                    .HasColumnName("Announcement_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AnnouncementDislike).HasColumnName("Announcement_dislike");

                entity.Property(e => e.AnnouncementLike).HasColumnName("Announcement_like");

                entity.Property(e => e.AnnouncementRating).HasColumnName("Announcement_rating");

                entity.Property(e => e.AnnouncementTema)
                    .IsRequired()
                    .HasColumnName("Announcement_tema")
                    .HasMaxLength(150);

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.HasOne(d => d.AnnouncementCategory)
                    .WithMany(p => p.Announcement)
                    .HasForeignKey(d => d.AnnouncementCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_145");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Announcement)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_154");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Announcement)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_146");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Announcement)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_130");
            });

            modelBuilder.Entity<AnnouncementCategoryList>(entity =>
            {
                entity.HasKey(e => e.AnnouncementCategoryId);

                entity.ToTable("Announcement_category_list");

                entity.Property(e => e.AnnouncementCategoryId)
                    .HasColumnName("Announcement_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AnnouncementTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Announcement_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnnouncementId).HasColumnName("Announcement_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.AnnouncementTag)
                    .HasForeignKey<AnnouncementTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_37");
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("RoleNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId });

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId)
                    .HasName("IX_RoleId");

                entity.HasIndex(e => e.UserId)
                    .HasName("IX_UserId");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.UserName)
                    .HasName("UserNameIndex")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasMaxLength(128)
                    .ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Auctioneer>(entity =>
            {
                entity.Property(e => e.AuctioneerId)
                    .HasColumnName("Auctioneer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuctioneerCategoryId).HasColumnName("Auctioneer_category_id");

                entity.Property(e => e.AuctioneerComment)
                    .HasColumnName("Auctioneer_comment")
                    .HasMaxLength(400);

                entity.Property(e => e.AuctioneerDate)
                    .HasColumnName("Auctioneer_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuctioneerDirection)
                    .HasColumnName("Auctioneer_direction")
                    .HasMaxLength(1);

                entity.Property(e => e.AuctioneerEndDate)
                    .HasColumnName("Auctioneer_end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuctioneerName)
                    .IsRequired()
                    .HasColumnName("Auctioneer_name")
                    .HasMaxLength(300);

                entity.Property(e => e.AuctioneerPrice).HasColumnName("Auctioneer_price");

                entity.Property(e => e.AuctioneerPriceStep).HasColumnName("Auctioneer_price_step");

                entity.Property(e => e.AuctioneerPriceUid).HasColumnName("Auctioneer_price_uid");

                entity.Property(e => e.AuctioneerRansomPrice).HasColumnName("Auctioneer_ransom_price");

                entity.Property(e => e.AuctioneerStartPrice).HasColumnName("Auctioneer_start_price");

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.HasOne(d => d.AuctioneerCategory)
                    .WithMany(p => p.Auctioneer)
                    .HasForeignKey(d => d.AuctioneerCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_147");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Auctioneer)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_155");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Auctioneer)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_148");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Auctioneer)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_131");
            });

            modelBuilder.Entity<AuctioneerCategoryList>(entity =>
            {
                entity.HasKey(e => e.AuctioneerCategoryId);

                entity.ToTable("Auctioneer_category_list");

                entity.Property(e => e.AuctioneerCategoryId)
                    .HasColumnName("Auctioneer_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AuctioneerHistory>(entity =>
            {
                entity.HasKey(e => e.AuctioneerId);

                entity.ToTable("Auctioneer_history");

                entity.Property(e => e.AuctioneerId)
                    .HasColumnName("Auctioneer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AucHistoryAction)
                    .IsRequired()
                    .HasColumnName("Auc_history_action")
                    .HasMaxLength(250);

                entity.Property(e => e.AucHistoryDateTime)
                    .HasColumnName("Auc_history_date_time")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Auctioneer)
                    .WithOne(p => p.AuctioneerHistory)
                    .HasForeignKey<AuctioneerHistory>(d => d.AuctioneerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_97");
            });

            modelBuilder.Entity<AuctioneerTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Auctioneer_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuctioneerId).HasColumnName("Auctioneer_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.AuctioneerTag)
                    .HasForeignKey<AuctioneerTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_39");
            });

            modelBuilder.Entity<BlogCategoryList>(entity =>
            {
                entity.HasKey(e => e.BlogCategoryId);

                entity.ToTable("Blog_category_list");

                entity.Property(e => e.BlogCategoryId)
                    .HasColumnName("Blog_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<BlogList>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.ToTable("Blog_list");

                entity.Property(e => e.BlogId)
                    .HasColumnName("Blog_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogCategoryId).HasColumnName("Blog_category_id");

                entity.Property(e => e.BlogDislike).HasColumnName("Blog_dislike");

                entity.Property(e => e.BlogLike).HasColumnName("Blog_like");

                entity.Property(e => e.BlogName)
                    .IsRequired()
                    .HasColumnName("Blog_name")
                    .HasMaxLength(100);

                entity.Property(e => e.BlogRating).HasColumnName("Blog_rating");

                entity.Property(e => e.BlogSlogon)
                    .HasColumnName("Blog_slogon")
                    .HasMaxLength(250);

                entity.Property(e => e.BlogStatus)
                    .IsRequired()
                    .HasColumnName("Blog_status")
                    .HasMaxLength(20);

                entity.Property(e => e.BlogSubscribersNum).HasColumnName("Blog_subscribers_num");

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.BlogList)
                    .HasForeignKey(d => d.BlogCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_157");
            });

            modelBuilder.Entity<BlogPostComments>(entity =>
            {
                entity.HasKey(e => new { e.BlogPostId, e.BlogPostComId });

                entity.ToTable("Blog_post_comments");

                entity.Property(e => e.BlogPostId).HasColumnName("Blog_post_id");

                entity.Property(e => e.BlogPostComId).HasColumnName("Blog_post_com_id");

                entity.Property(e => e.BlogPostComBody)
                    .IsRequired()
                    .HasColumnName("Blog_post_com_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.BlogPostComData)
                    .HasColumnName("Blog_post_com_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.BlogPostComDislike).HasColumnName("Blog_post_com_dislike");

                entity.Property(e => e.BlogPostComLike).HasColumnName("Blog_post_com_like");

                entity.HasOne(d => d.BlogPost)
                    .WithMany(p => p.BlogPostComments)
                    .HasForeignKey(d => d.BlogPostId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_119");
            });

            modelBuilder.Entity<BlogPostCommentsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Blog_post_comments_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogId).HasColumnName("Blog_id");

                entity.Property(e => e.BlogPostComId).HasColumnName("Blog_post_com_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.BlogPostCommentsTag)
                    .HasForeignKey<BlogPostCommentsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_50");
            });

            modelBuilder.Entity<BlogPostTable>(entity =>
            {
                entity.HasKey(e => e.BlogPostId);

                entity.ToTable("Blog_post_table");

                entity.Property(e => e.BlogPostId)
                    .HasColumnName("Blog_post_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogPostBody)
                    .IsRequired()
                    .HasColumnName("Blog_post_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.BlogPostData)
                    .HasColumnName("Blog_post_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.BlogPostDislike).HasColumnName("Blog_post_dislike");

                entity.Property(e => e.BlogPostLike).HasColumnName("Blog_post_like");

                entity.Property(e => e.BlogPostRating).HasColumnName("Blog_post_rating");

                entity.Property(e => e.BlogPostTema)
                    .IsRequired()
                    .HasColumnName("Blog_post_tema")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BlogPostTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Blog_post_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogId).HasColumnName("Blog_id");

                entity.Property(e => e.BlogPostId).HasColumnName("Blog_post_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.BlogPostTag)
                    .HasForeignKey<BlogPostTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_49");
            });

            modelBuilder.Entity<BlogStatusList>(entity =>
            {
                entity.HasKey(e => e.BlogStatusId);

                entity.ToTable("Blog_status_list");

                entity.Property(e => e.BlogStatusId)
                    .HasColumnName("Blog_status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<BlogUserTable>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.ToTable("Blog_user_table");

                entity.Property(e => e.BlogId)
                    .HasColumnName("Blog_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogStatusId).HasColumnName("Blog_status_id");

                entity.HasOne(d => d.Blog)
                    .WithOne(p => p.BlogUserTable)
                    .HasForeignKey<BlogUserTable>(d => d.BlogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_122");

                entity.HasOne(d => d.BlogStatus)
                    .WithMany(p => p.BlogUserTable)
                    .HasForeignKey(d => d.BlogStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_158");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.BlogUserTable)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_159");
            });

            modelBuilder.Entity<ChatTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Chat_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllChatMessId).HasColumnName("All_chat_mess_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.ChatTag)
                    .HasForeignKey<ChatTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_38");
            });

            modelBuilder.Entity<CityList>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("City_list");

                entity.Property(e => e.CityId)
                    .HasColumnName("City_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CommentsAnnouncement>(entity =>
            {
                entity.HasKey(e => new { e.ComAnnouncementId, e.AnnouncementId });

                entity.ToTable("Comments_announcement");

                entity.Property(e => e.ComAnnouncementId).HasColumnName("Com_announcement_id");

                entity.Property(e => e.AnnouncementId).HasColumnName("Announcement_id");

                entity.Property(e => e.ComAnnouncementBody)
                    .IsRequired()
                    .HasColumnName("Com_announcement_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.ComAnnouncementDate)
                    .HasColumnName("Com_announcement_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComAnnouncementDislike).HasColumnName("Com_announcement_dislike");

                entity.Property(e => e.ComAnnouncementLike).HasColumnName("Com_announcement_like");

                entity.HasOne(d => d.Announcement)
                    .WithMany(p => p.CommentsAnnouncement)
                    .HasForeignKey(d => d.AnnouncementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_93");
            });

            modelBuilder.Entity<CommentsAnnouncementTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Comments_announcement_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComAnnouncementId).HasColumnName("Com_announcement_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsAnnouncementTag)
                    .HasForeignKey<CommentsAnnouncementTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_40");
            });

            modelBuilder.Entity<CommentsEshop>(entity =>
            {
                entity.HasKey(e => new { e.CommentsEshopId, e.ShopId });

                entity.ToTable("Comments_eshop");

                entity.Property(e => e.CommentsEshopId).HasColumnName("Comments_eshop_id");

                entity.Property(e => e.ShopId).HasColumnName("Shop_id");

                entity.Property(e => e.CommentsEshopBody)
                    .HasColumnName("Comments_eshop_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.CommentsEshopDate)
                    .HasColumnName("Comments_eshop_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CommentsEshopDislike).HasColumnName("Comments_eshop_dislike");

                entity.Property(e => e.CommentsEshopLike).HasColumnName("Comments_eshop_like");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.CommentsEshop)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_71");
            });

            modelBuilder.Entity<CommentsNews>(entity =>
            {
                entity.HasKey(e => new { e.ComNewsId, e.NewsId });

                entity.ToTable("Comments_news");

                entity.Property(e => e.ComNewsId).HasColumnName("Com_news_id");

                entity.Property(e => e.NewsId).HasColumnName("News_id");

                entity.Property(e => e.ComNewsBody)
                    .IsRequired()
                    .HasColumnName("Com_news_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.ComNewsDate)
                    .HasColumnName("Com_news_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComNewsDislike).HasColumnName("Com_news_dislike");

                entity.Property(e => e.ComNewsLike).HasColumnName("Com_news_like");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.CommentsNews)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_91");
            });

            modelBuilder.Entity<CommentsNewsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Comments_news_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComNewsId).HasColumnName("Com_news_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsNewsTag)
                    .HasForeignKey<CommentsNewsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_42");
            });

            modelBuilder.Entity<CommentsPlaces>(entity =>
            {
                entity.HasKey(e => new { e.ComPlasesId, e.PlacesId });

                entity.ToTable("Comments_places");

                entity.Property(e => e.ComPlasesId).HasColumnName("Com_plases_id");

                entity.Property(e => e.PlacesId).HasColumnName("Places_id");

                entity.Property(e => e.ComPlasesBody)
                    .IsRequired()
                    .HasColumnName("Com_plases_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.ComPlasesDate)
                    .HasColumnName("Com_plases_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComPlasesDislike).HasColumnName("Com_plases_dislike");

                entity.Property(e => e.ComPlasesLike).HasColumnName("Com_plases_like");

                entity.HasOne(d => d.Places)
                    .WithMany(p => p.CommentsPlaces)
                    .HasForeignKey(d => d.PlacesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_88");
            });

            modelBuilder.Entity<CommentsPlacesTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Comments_places_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComPlacesId).HasColumnName("Com_places_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsPlacesTag)
                    .HasForeignKey<CommentsPlacesTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_41");
            });

            modelBuilder.Entity<CommentsPoster>(entity =>
            {
                entity.HasKey(e => new { e.ComPosterId, e.PosterId });

                entity.ToTable("Comments_poster");

                entity.Property(e => e.ComPosterId).HasColumnName("Com_poster_id");

                entity.Property(e => e.PosterId).HasColumnName("Poster_id");

                entity.Property(e => e.ComPosterBody)
                    .IsRequired()
                    .HasColumnName("Com_poster_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.ComPosterDate)
                    .HasColumnName("Com_poster_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ComPosterDislike).HasColumnName("Com_poster_dislike");

                entity.Property(e => e.ComPosterLike).HasColumnName("Com_poster_like");

                entity.HasOne(d => d.Poster)
                    .WithMany(p => p.CommentsPoster)
                    .HasForeignKey(d => d.PosterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_81");
            });

            modelBuilder.Entity<CommentsPosterTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Comments_poster_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComPosterId).HasColumnName("Com_poster_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsPosterTag)
                    .HasForeignKey<CommentsPosterTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_43");
            });

            modelBuilder.Entity<CountryList>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("Country_list");

                entity.Property(e => e.CountryId)
                    .HasColumnName("Country_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<GoodsCategoryList>(entity =>
            {
                entity.HasKey(e => e.GoodsCategoryId);

                entity.ToTable("Goods_category_list");

                entity.Property(e => e.GoodsCategoryId)
                    .HasColumnName("Goods_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasMaxLength(150);
            });

            modelBuilder.Entity<GoodsPhotoId>(entity =>
            {
                entity.HasKey(e => e.GoodsPhotoId1);

                entity.ToTable("Goods_photo_id");

                entity.Property(e => e.GoodsPhotoId1)
                    .HasColumnName("Goods_photo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GoodsId).HasColumnName("Goods_id");

                entity.Property(e => e.GoodsPhotoComments)
                    .HasColumnName("Goods_photo_comments")
                    .HasMaxLength(300);

                entity.Property(e => e.GoodsPhotoPath)
                    .HasColumnName("Goods_photo_path")
                    .HasMaxLength(150);

                entity.Property(e => e.ShopId).HasColumnName("Shop_id");

                entity.HasOne(d => d.ShopGoodsList)
                    .WithMany(p => p.GoodsPhotoId)
                    .HasForeignKey(d => new { d.GoodsId, d.ShopId })
                    .HasConstraintName("R_69");
            });

            modelBuilder.Entity<GoodsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Goods_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GoodsId).HasColumnName("Goods_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.GoodsTag)
                    .HasForeignKey<GoodsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_62");
            });

            modelBuilder.Entity<LanguageList>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("Language_list");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("Language_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LikeDislikeList>(entity =>
            {
                entity.HasKey(e => new { e.LikeDislikeId, e.Uid });

                entity.ToTable("Like_dislike_list");

                entity.Property(e => e.LikeDislikeId).HasColumnName("Like_dislike_id");

                entity.Property(e => e.LikeDislikeAnnouncementId).HasColumnName("Like_dislike_announcement_id");

                entity.Property(e => e.LikeDislikeAuctioneerId).HasColumnName("Like_dislike_auctioneer_id");

                entity.Property(e => e.LikeDislikeBlogPostCommentsId).HasColumnName("Like_dislike_blog_post_comments_id");

                entity.Property(e => e.LikeDislikeBlogPostId).HasColumnName("Like_dislike_blog_post_id");

                entity.Property(e => e.LikeDislikeChatId).HasColumnName("Like_dislike_chat_id");

                entity.Property(e => e.LikeDislikeCommentsAnnouncementId).HasColumnName("Like_dislike_comments_announcement_id");

                entity.Property(e => e.LikeDislikeCommentsNewsId).HasColumnName("Like_dislike_comments_news_id");

                entity.Property(e => e.LikeDislikeCommentsPlacesId).HasColumnName("Like_dislike_comments_places_id");

                entity.Property(e => e.LikeDislikeCommentsPosterId).HasColumnName("Like_dislike_comments_poster_id");

                entity.Property(e => e.LikeDislikeGoodsId).HasColumnName("Like_dislike_goods_id");

                entity.Property(e => e.LikeDislikeNewsId).HasColumnName("Like_dislike_news_id");

                entity.Property(e => e.LikeDislikePlacesId).HasColumnName("Like_dislike_places_id");

                entity.Property(e => e.LikeDislikePosterId).HasColumnName("Like_dislike_poster_id");

                entity.Property(e => e.LikeDislikeUserId).HasColumnName("Like_dislike_user_id");

                entity.Property(e => e.LikeDislikeUserUseId).HasColumnName("Like_dislike_user_use_id");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.LikeDislikeList)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_72");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey });

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.NewsId)
                    .HasColumnName("News_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.NewsBody)
                    .IsRequired()
                    .HasColumnName("News_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.NewsCategoryId).HasColumnName("News_category_id");

                entity.Property(e => e.NewsDate)
                    .HasColumnName("News_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewsDislike).HasColumnName("News_dislike");

                entity.Property(e => e.NewsLike).HasColumnName("News_like");

                entity.Property(e => e.NewsRating).HasColumnName("News_rating");

                entity.Property(e => e.NewsTema)
                    .IsRequired()
                    .HasColumnName("News_tema")
                    .HasMaxLength(150);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_153");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_144");

                entity.HasOne(d => d.NewsCategory)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.NewsCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_143");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_129");
            });

            modelBuilder.Entity<NewsCategoryList>(entity =>
            {
                entity.HasKey(e => e.NewsCategoryId);

                entity.ToTable("News_category_list");

                entity.Property(e => e.NewsCategoryId)
                    .HasColumnName("News_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<NewsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("News_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NewsId).HasColumnName("News_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.NewsTag)
                    .HasForeignKey<NewsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_34");
            });

            modelBuilder.Entity<OnlineList>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("Online_list");

                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.StatusId).HasColumnName("Status_id");

                entity.Property(e => e.UserGuid).HasColumnName("User_guid");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OnlineList)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_137");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.OnlineList)
                    .HasForeignKey<OnlineList>(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_100");
            });

            modelBuilder.Entity<Places>(entity =>
            {
                entity.Property(e => e.PlacesId)
                    .HasColumnName("Places_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.PlacesBody)
                    .IsRequired()
                    .HasColumnName("Places_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.PlacesCategoryId).HasColumnName("Places_category_id");

                entity.Property(e => e.PlacesDate)
                    .HasColumnName("Places_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlacesDislike).HasColumnName("Places_dislike");

                entity.Property(e => e.PlacesLike).HasColumnName("Places_like");

                entity.Property(e => e.PlacesRating).HasColumnName("Places_rating");

                entity.Property(e => e.PlacesStartDate)
                    .HasColumnName("Places_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlacesTema)
                    .IsRequired()
                    .HasColumnName("Places_tema")
                    .HasMaxLength(150);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_152");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_142");

                entity.HasOne(d => d.PlacesCategory)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.PlacesCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_141");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_128");
            });

            modelBuilder.Entity<PlacesCategoryList>(entity =>
            {
                entity.HasKey(e => e.PlacesCategoryId);

                entity.ToTable("Places_category_list");

                entity.Property(e => e.PlacesCategoryId)
                    .HasColumnName("Places_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PlacesTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Places_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PlacesId).HasColumnName("Places_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.PlacesTag)
                    .HasForeignKey<PlacesTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_33");
            });

            modelBuilder.Entity<Poster>(entity =>
            {
                entity.Property(e => e.PosterId)
                    .HasColumnName("Poster_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.PosterBody)
                    .IsRequired()
                    .HasColumnName("Poster_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.PosterCategoryId).HasColumnName("Poster_category_id");

                entity.Property(e => e.PosterDate)
                    .HasColumnName("Poster_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosterDislike).HasColumnName("Poster_dislike");

                entity.Property(e => e.PosterLike).HasColumnName("Poster_like");

                entity.Property(e => e.PosterRating).HasColumnName("Poster_rating");

                entity.Property(e => e.PosterStartDate)
                    .HasColumnName("Poster_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosterTema)
                    .IsRequired()
                    .HasColumnName("Poster_tema")
                    .HasMaxLength(150);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Poster)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_151");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Poster)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_140");

                entity.HasOne(d => d.PosterCategory)
                    .WithMany(p => p.Poster)
                    .HasForeignKey(d => d.PosterCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_138");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Poster)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_127");
            });

            modelBuilder.Entity<PosterCategoryList>(entity =>
            {
                entity.HasKey(e => e.PosterCategoryId);

                entity.ToTable("Poster_category_list");

                entity.Property(e => e.PosterCategoryId)
                    .HasColumnName("Poster_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PosterTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Poster_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosterId).HasColumnName("Poster_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.PosterTag)
                    .HasForeignKey<PosterTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_32");
            });

            modelBuilder.Entity<RoomChatId>(entity =>
            {
                entity.HasKey(e => e.RoomId);

                entity.ToTable("Room_chat_id");

                entity.Property(e => e.RoomId)
                    .HasColumnName("Room_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RoomName)
                    .HasColumnName("Room_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SexList>(entity =>
            {
                entity.HasKey(e => e.SexId);

                entity.ToTable("Sex_list");

                entity.Property(e => e.SexId)
                    .HasColumnName("Sex_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.ShopId)
                    .HasColumnName("Shop_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.ShopComments)
                    .IsRequired()
                    .HasColumnName("Shop_comments")
                    .HasMaxLength(300);

                entity.Property(e => e.ShopDislike).HasColumnName("Shop_dislike");

                entity.Property(e => e.ShopLike).HasColumnName("Shop_like");

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasColumnName("Shop_name")
                    .HasMaxLength(150);

                entity.Property(e => e.ShopRating).HasColumnName("Shop_rating");

                entity.Property(e => e.ShopRegDate)
                    .HasColumnName("Shop_reg_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShopSlogon)
                    .HasColumnName("Shop_slogon")
                    .HasMaxLength(1000);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("R_57");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("R_58");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Shop)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("R_56");
            });

            modelBuilder.Entity<ShopGoodsList>(entity =>
            {
                entity.HasKey(e => new { e.GoodsId, e.ShopId });

                entity.ToTable("Shop_goods_list");

                entity.Property(e => e.GoodsId).HasColumnName("Goods_id");

                entity.Property(e => e.ShopId).HasColumnName("Shop_id");

                entity.Property(e => e.GoodsCategoryId).HasColumnName("Goods_category_id");

                entity.Property(e => e.GoodsDescription)
                    .HasColumnName("Goods_description")
                    .HasMaxLength(300);

                entity.Property(e => e.GoodsName)
                    .HasColumnName("Goods_name")
                    .HasMaxLength(300);

                entity.Property(e => e.GoodsPrice).HasColumnName("Goods_price");

                entity.HasOne(d => d.GoodsCategory)
                    .WithMany(p => p.ShopGoodsList)
                    .HasForeignKey(d => d.GoodsCategoryId)
                    .HasConstraintName("R_68");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.ShopGoodsList)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_70");
            });

            modelBuilder.Entity<SkinList>(entity =>
            {
                entity.HasKey(e => e.SkinId);

                entity.ToTable("Skin_list");

                entity.Property(e => e.SkinId)
                    .HasColumnName("Skin_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkinName)
                    .IsRequired()
                    .HasColumnName("Skin_name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<StatusList>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("Status_list");

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SysMessage>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("Sys_message");

                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.SysMessage1)
                    .HasColumnName("Sys_message")
                    .HasMaxLength(200);

                entity.Property(e => e.SysMessageDate)
                    .HasColumnName("Sys_message_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.SysMessage)
                    .HasForeignKey<SysMessage>(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_67");
            });

            modelBuilder.Entity<TagList>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("Tag_list");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnnouncementCount).HasColumnName("Announcement_count");

                entity.Property(e => e.AuctioneerCount).HasColumnName("Auctioneer_count");

                entity.Property(e => e.BlogPostCommentsCount).HasColumnName("Blog_post_comments_count");

                entity.Property(e => e.BlogPostCount).HasColumnName("Blog_post_count");

                entity.Property(e => e.ChatCount).HasColumnName("Chat_count");

                entity.Property(e => e.CommentsAnnouncementCount).HasColumnName("Comments_announcement_count");

                entity.Property(e => e.CommentsNewsCount).HasColumnName("Comments_news_count");

                entity.Property(e => e.CommentsPlacesCount).HasColumnName("Comments_places_count");

                entity.Property(e => e.CommentsPosterCount).HasColumnName("Comments_poster_count");

                entity.Property(e => e.GoodsCount).HasColumnName("Goods_count");

                entity.Property(e => e.NewsCount).HasColumnName("News_count");

                entity.Property(e => e.PlacesCount).HasColumnName("Places_count");

                entity.Property(e => e.PosterCount).HasColumnName("Poster_count");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnName("Tag_name")
                    .HasMaxLength(200);

                entity.Property(e => e.UserCount).HasColumnName("User_count");

                entity.Property(e => e.UserUseCount).HasColumnName("User_use_count");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("City_id");

                entity.Property(e => e.CountryId).HasColumnName("Country_id");

                entity.Property(e => e.SexId).HasColumnName("Sex_id");

                entity.Property(e => e.UserAvator)
                    .HasColumnName("User_avator")
                    .HasMaxLength(100);

                entity.Property(e => e.UserBonusCount).HasColumnName("User_bonus_count");

                entity.Property(e => e.UserDateOfBirth)
                    .HasColumnName("User_date_of_birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDislike).HasColumnName("User_dislike");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("User_email")
                    .HasMaxLength(100);

                entity.Property(e => e.UserFirstname)
                    .IsRequired()
                    .HasColumnName("User_firstname")
                    .HasMaxLength(100);

                entity.Property(e => e.UserLastOnline)
                    .HasColumnName("User_last_online")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserLastname)
                    .IsRequired()
                    .HasColumnName("User_lastname")
                    .HasMaxLength(100);

                entity.Property(e => e.UserLike).HasColumnName("User_like");

                entity.Property(e => e.UserLocation)
                    .HasColumnName("User_location")
                    .HasMaxLength(20);

                entity.Property(e => e.UserLogFile)
                    .HasColumnName("User_log_file")
                    .HasColumnType("xml");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("User_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserNikname)
                    .IsRequired()
                    .HasColumnName("User_nikname")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("User_password")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPasswordHistory)
                    .HasColumnName("User_password_history")
                    .HasColumnType("xml");

                entity.Property(e => e.UserPremiumStatus)
                    .HasColumnName("User_premium_status")
                    .HasMaxLength(1);

                entity.Property(e => e.UserRating).HasColumnName("User_rating");

                entity.Property(e => e.UserRegDate)
                    .HasColumnName("User_reg_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserSlogon)
                    .HasColumnName("User_slogon")
                    .HasMaxLength(300);

                entity.Property(e => e.UserTel)
                    .IsRequired()
                    .HasColumnName("User_tel")
                    .HasMaxLength(20);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_135");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_134");

                entity.HasOne(d => d.Sex)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SexId)
                    .HasConstraintName("R_136");
            });

            modelBuilder.Entity<UserSettings>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("User_settings");

                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.UserSettingsGps)
                    .HasColumnName("User_settings_gps")
                    .HasMaxLength(1);

                entity.Property(e => e.UserSettingsLanguageId).HasColumnName("User_settings_language_id");

                entity.Property(e => e.UserSettingsSkinId).HasColumnName("User_settings_skin_id");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.UserSettings)
                    .HasForeignKey<UserSettings>(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_55");

                entity.HasOne(d => d.UserSettingsLanguage)
                    .WithMany(p => p.UserSettings)
                    .HasForeignKey(d => d.UserSettingsLanguageId)
                    .HasConstraintName("R_149");

                entity.HasOne(d => d.UserSettingsSkin)
                    .WithMany(p => p.UserSettings)
                    .HasForeignKey(d => d.UserSettingsSkinId)
                    .HasConstraintName("R_150");
            });

            modelBuilder.Entity<UserTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("User_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.UserTag)
                    .HasForeignKey<UserTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_30");
            });

            modelBuilder.Entity<UserUseTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("User_use_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("Tag_id")
                    .ValueGeneratedNever();

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.UserUseTag)
                    .HasForeignKey<UserUseTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_35");
            });
        }
    }
}
