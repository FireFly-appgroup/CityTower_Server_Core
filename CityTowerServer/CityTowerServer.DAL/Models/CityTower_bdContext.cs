using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CityTowerServer.DAL.Models
{
    public partial class CityTower_bdContext : DbContext
    {
        public CityTower_bdContext()
        {
        }

        public CityTower_bdContext(DbContextOptions<CityTower_bdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ad> Ad { get; set; }
        public virtual DbSet<AdCategoryList> AdCategoryList { get; set; }
        public virtual DbSet<AdTag> AdTag { get; set; }
        public virtual DbSet<AllChat> AllChat { get; set; }
        public virtual DbSet<Auctioneer> Auctioneer { get; set; }
        public virtual DbSet<AuctioneerCategoryList> AuctioneerCategoryList { get; set; }
        public virtual DbSet<AuctioneerHistory> AuctioneerHistory { get; set; }
        public virtual DbSet<AuctioneerTag> AuctioneerTag { get; set; }
        public virtual DbSet<BlogBlogIdPostComments> BlogBlogIdPostComments { get; set; }
        public virtual DbSet<BlogBlogIdPostTable> BlogBlogIdPostTable { get; set; }
        public virtual DbSet<BlogCategoryList> BlogCategoryList { get; set; }
        public virtual DbSet<BlogList> BlogList { get; set; }
        public virtual DbSet<BlogPostCommentsTag> BlogPostCommentsTag { get; set; }
        public virtual DbSet<BlogPostTag> BlogPostTag { get; set; }
        public virtual DbSet<BlogStatusList> BlogStatusList { get; set; }
        public virtual DbSet<BlogUserTable> BlogUserTable { get; set; }
        public virtual DbSet<ChatTag> ChatTag { get; set; }
        public virtual DbSet<CityList> CityList { get; set; }
        public virtual DbSet<CommentsAd> CommentsAd { get; set; }
        public virtual DbSet<CommentsAdTag> CommentsAdTag { get; set; }
        public virtual DbSet<CommentsEshop> CommentsEshop { get; set; }
        public virtual DbSet<CommentsNews> CommentsNews { get; set; }
        public virtual DbSet<CommentsNewsTag> CommentsNewsTag { get; set; }
        public virtual DbSet<CommentsPlaces> CommentsPlaces { get; set; }
        public virtual DbSet<CommentsPlacesTag> CommentsPlacesTag { get; set; }
        public virtual DbSet<CommentsPoster> CommentsPoster { get; set; }
        public virtual DbSet<CommentsPosterTag> CommentsPosterTag { get; set; }
        public virtual DbSet<CountryList> CountryList { get; set; }
        public virtual DbSet<Eshop> Eshop { get; set; }
        public virtual DbSet<EshopGoodsList> EshopGoodsList { get; set; }
        public virtual DbSet<GoodsCategoryList> GoodsCategoryList { get; set; }
        public virtual DbSet<GoodsPhotoId> GoodsPhotoId { get; set; }
        public virtual DbSet<GoodsTag> GoodsTag { get; set; }
        public virtual DbSet<LanguageList> LanguageList { get; set; }
        public virtual DbSet<LikeDislikeList> LikeDislikeList { get; set; }
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
        public virtual DbSet<SexList> SexList { get; set; }
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
                optionsBuilder.UseSqlServer("Server=localhost;Database=CityTower_bd;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ad>(entity =>
            {
                entity.ToTable("ad");

                entity.Property(e => e.AdId)
                    .HasColumnName("ad_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdBody)
                    .IsRequired()
                    .HasColumnName("ad_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.AdCategoryId).HasColumnName("ad_category_id");

                entity.Property(e => e.AdDate)
                    .HasColumnName("ad_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AdTema)
                    .IsRequired()
                    .HasColumnName("ad_tema")
                    .HasMaxLength(150);

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.AdCategory)
                    .WithMany(p => p.Ad)
                    .HasForeignKey(d => d.AdCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_145");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Ad)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_154");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Ad)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_146");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Ad)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_130");
            });

            modelBuilder.Entity<AdCategoryList>(entity =>
            {
                entity.HasKey(e => e.AdCategoryId);

                entity.ToTable("ad_category_list");

                entity.Property(e => e.AdCategoryId)
                    .HasColumnName("ad_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AdTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("ad_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdId).HasColumnName("ad_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.AdTag)
                    .HasForeignKey<AdTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_37");
            });

            modelBuilder.Entity<AllChat>(entity =>
            {
                entity.HasKey(e => e.MessId);

                entity.ToTable("all_chat");

                entity.Property(e => e.MessId)
                    .HasColumnName("mess_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.MessBody)
                    .IsRequired()
                    .HasColumnName("mess_body")
                    .HasMaxLength(300);

                entity.Property(e => e.MessDate)
                    .HasColumnName("mess_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AllChat)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_156");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.AllChat)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_132");
            });

            modelBuilder.Entity<Auctioneer>(entity =>
            {
                entity.ToTable("auctioneer");

                entity.Property(e => e.AuctioneerId)
                    .HasColumnName("auctioneer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuctioneerCategoryId).HasColumnName("auctioneer_category_id");

                entity.Property(e => e.AuctioneerComment)
                    .HasColumnName("auctioneer_comment")
                    .HasMaxLength(400);

                entity.Property(e => e.AuctioneerDate)
                    .HasColumnName("auctioneer_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuctioneerDirection)
                    .HasColumnName("auctioneer_direction")
                    .HasMaxLength(1);

                entity.Property(e => e.AuctioneerEndDate)
                    .HasColumnName("auctioneer_end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AuctioneerName)
                    .IsRequired()
                    .HasColumnName("auctioneer_name")
                    .HasMaxLength(300);

                entity.Property(e => e.AuctioneerPrice).HasColumnName("auctioneer_price");

                entity.Property(e => e.AuctioneerPriceStep).HasColumnName("auctioneer_price_step");

                entity.Property(e => e.AuctioneerPriceUid).HasColumnName("auctioneer_price_uid");

                entity.Property(e => e.AuctioneerRansomPrice).HasColumnName("auctioneer_ransom_price");

                entity.Property(e => e.AuctioneerStartPrice).HasColumnName("auctioneer_start_price");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.Uid).HasColumnName("uid");

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

                entity.ToTable("auctioneer_category_list");

                entity.Property(e => e.AuctioneerCategoryId)
                    .HasColumnName("auctioneer_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<AuctioneerHistory>(entity =>
            {
                entity.HasKey(e => e.AuctioneerId);

                entity.ToTable("auctioneer_history");

                entity.Property(e => e.AuctioneerId)
                    .HasColumnName("auctioneer_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Act)
                    .IsRequired()
                    .HasColumnName("act")
                    .HasMaxLength(250);

                entity.Property(e => e.DateTime)
                    .HasColumnName("date_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Auctioneer)
                    .WithOne(p => p.AuctioneerHistory)
                    .HasForeignKey<AuctioneerHistory>(d => d.AuctioneerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_97");
            });

            modelBuilder.Entity<AuctioneerTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("auctioneer_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuctioneerId).HasColumnName("auctioneer_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.AuctioneerTag)
                    .HasForeignKey<AuctioneerTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_39");
            });

            modelBuilder.Entity<BlogBlogIdPostComments>(entity =>
            {
                entity.HasKey(e => new { e.BpId, e.BpcId });

                entity.ToTable("blog_blog_id_post_comments");

                entity.Property(e => e.BpId).HasColumnName("bp_id");

                entity.Property(e => e.BpcId).HasColumnName("bpc_id");

                entity.Property(e => e.BpcBody)
                    .IsRequired()
                    .HasColumnName("bpc_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.BpcData)
                    .HasColumnName("bpc_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.BpcDislike).HasColumnName("bpc_dislike");

                entity.Property(e => e.BpcLike).HasColumnName("bpc_like");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Bp)
                    .WithMany(p => p.BlogBlogIdPostComments)
                    .HasForeignKey(d => d.BpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_119");
            });

            modelBuilder.Entity<BlogBlogIdPostTable>(entity =>
            {
                entity.HasKey(e => e.BpId);

                entity.ToTable("blog_blog_id_post_table");

                entity.Property(e => e.BpId)
                    .HasColumnName("bp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogPostBody)
                    .IsRequired()
                    .HasColumnName("blog_post_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.BlogPostData)
                    .HasColumnName("blog_post_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.BlogPostDislike).HasColumnName("blog_post_dislike");

                entity.Property(e => e.BlogPostLike).HasColumnName("blog_post_like");

                entity.Property(e => e.BlogPostRating).HasColumnName("blog_post_rating");

                entity.Property(e => e.BlogPostTema)
                    .IsRequired()
                    .HasColumnName("blog_post_tema")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<BlogCategoryList>(entity =>
            {
                entity.HasKey(e => e.BlogCategoryId);

                entity.ToTable("blog_category_list");

                entity.Property(e => e.BlogCategoryId)
                    .HasColumnName("blog_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<BlogList>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.ToTable("blog_list");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogCategoryId).HasColumnName("blog_category_id");

                entity.Property(e => e.BlogDislike).HasColumnName("blog_dislike");

                entity.Property(e => e.BlogLike).HasColumnName("blog_like");

                entity.Property(e => e.BlogName)
                    .IsRequired()
                    .HasColumnName("blog_name")
                    .HasMaxLength(100);

                entity.Property(e => e.BlogRating).HasColumnName("blog_rating");

                entity.Property(e => e.BlogSlogon)
                    .HasColumnName("blog_slogon")
                    .HasMaxLength(250);

                entity.Property(e => e.BlogStatus)
                    .IsRequired()
                    .HasColumnName("blog_status")
                    .HasMaxLength(20);

                entity.Property(e => e.BlogSubscribersNum).HasColumnName("blog_subscribers_num");

                entity.HasOne(d => d.BlogCategory)
                    .WithMany(p => p.BlogList)
                    .HasForeignKey(d => d.BlogCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_157");
            });

            modelBuilder.Entity<BlogPostCommentsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("blog_post_comments_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.BpcId).HasColumnName("bpc_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.BlogPostCommentsTag)
                    .HasForeignKey<BlogPostCommentsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_50");
            });

            modelBuilder.Entity<BlogPostTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("blog_post_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bid).HasColumnName("bid");

                entity.Property(e => e.BpId).HasColumnName("bp_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.BlogPostTag)
                    .HasForeignKey<BlogPostTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_49");
            });

            modelBuilder.Entity<BlogStatusList>(entity =>
            {
                entity.HasKey(e => e.BlogStatusId);

                entity.ToTable("blog_status_list");

                entity.Property(e => e.BlogStatusId)
                    .HasColumnName("blog_status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<BlogUserTable>(entity =>
            {
                entity.HasKey(e => e.BlogId);

                entity.ToTable("blog_user_table");

                entity.Property(e => e.BlogId)
                    .HasColumnName("blog_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlogStatusId).HasColumnName("blog_status_id");

                entity.Property(e => e.Uid).HasColumnName("uid");

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

                entity.ToTable("chat_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessId).HasColumnName("mess_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.ChatTag)
                    .HasForeignKey<ChatTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_38");
            });

            modelBuilder.Entity<CityList>(entity =>
            {
                entity.HasKey(e => e.CityId);

                entity.ToTable("city_list");

                entity.Property(e => e.CityId)
                    .HasColumnName("city_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CommentsAd>(entity =>
            {
                entity.HasKey(e => new { e.Caid, e.AdId });

                entity.ToTable("comments_ad");

                entity.Property(e => e.Caid).HasColumnName("caid");

                entity.Property(e => e.AdId).HasColumnName("ad_id");

                entity.Property(e => e.CaBody)
                    .IsRequired()
                    .HasColumnName("ca_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.CaDate)
                    .HasColumnName("ca_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CaDislike).HasColumnName("ca_dislike");

                entity.Property(e => e.CaLike).HasColumnName("ca_like");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Ad)
                    .WithMany(p => p.CommentsAd)
                    .HasForeignKey(d => d.AdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_93");
            });

            modelBuilder.Entity<CommentsAdTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("comments_ad_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Caid).HasColumnName("caid");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsAdTag)
                    .HasForeignKey<CommentsAdTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_40");
            });

            modelBuilder.Entity<CommentsEshop>(entity =>
            {
                entity.HasKey(e => new { e.CesId, e.ShopId });

                entity.ToTable("comments_eshop");

                entity.Property(e => e.CesId).HasColumnName("ces_id");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.CesBody)
                    .HasColumnName("ces_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.CesDate)
                    .HasColumnName("ces_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CesDislike).HasColumnName("ces_dislike");

                entity.Property(e => e.CesLike).HasColumnName("ces_like");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.CommentsEshop)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_71");
            });

            modelBuilder.Entity<CommentsNews>(entity =>
            {
                entity.HasKey(e => new { e.Cnid, e.NewsId });

                entity.ToTable("comments_news");

                entity.Property(e => e.Cnid).HasColumnName("cnid");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.CnBody)
                    .IsRequired()
                    .HasColumnName("cn_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.CnDate)
                    .HasColumnName("cn_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnDislike).HasColumnName("cn_dislike");

                entity.Property(e => e.CnLike).HasColumnName("cn_like");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.News)
                    .WithMany(p => p.CommentsNews)
                    .HasForeignKey(d => d.NewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_91");
            });

            modelBuilder.Entity<CommentsNewsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("comments_news_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cnid).HasColumnName("cnid");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsNewsTag)
                    .HasForeignKey<CommentsNewsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_42");
            });

            modelBuilder.Entity<CommentsPlaces>(entity =>
            {
                entity.HasKey(e => new { e.Cplid, e.PlacesId });

                entity.ToTable("comments_places");

                entity.Property(e => e.Cplid).HasColumnName("cplid");

                entity.Property(e => e.PlacesId).HasColumnName("places_id");

                entity.Property(e => e.CplBody)
                    .IsRequired()
                    .HasColumnName("cpl_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.CplDate)
                    .HasColumnName("cpl_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CplDislike).HasColumnName("cpl_dislike");

                entity.Property(e => e.CplLike).HasColumnName("cpl_like");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Places)
                    .WithMany(p => p.CommentsPlaces)
                    .HasForeignKey(d => d.PlacesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_88");
            });

            modelBuilder.Entity<CommentsPlacesTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("comments_places_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cplid).HasColumnName("cplid");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsPlacesTag)
                    .HasForeignKey<CommentsPlacesTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_41");
            });

            modelBuilder.Entity<CommentsPoster>(entity =>
            {
                entity.HasKey(e => new { e.Cpid, e.PosterId });

                entity.ToTable("comments_poster");

                entity.Property(e => e.Cpid).HasColumnName("cpid");

                entity.Property(e => e.PosterId).HasColumnName("poster_id");

                entity.Property(e => e.CpBody)
                    .IsRequired()
                    .HasColumnName("cp_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.CpDate)
                    .HasColumnName("cp_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CpDislike).HasColumnName("cp_dislike");

                entity.Property(e => e.CpLike).HasColumnName("cp_like");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Poster)
                    .WithMany(p => p.CommentsPoster)
                    .HasForeignKey(d => d.PosterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_81");
            });

            modelBuilder.Entity<CommentsPosterTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("comments_poster_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cpid).HasColumnName("cpid");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.CommentsPosterTag)
                    .HasForeignKey<CommentsPosterTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_43");
            });

            modelBuilder.Entity<CountryList>(entity =>
            {
                entity.HasKey(e => e.CountryId);

                entity.ToTable("country_list");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Eshop>(entity =>
            {
                entity.HasKey(e => e.ShopId);

                entity.ToTable("eshop");

                entity.Property(e => e.ShopId)
                    .HasColumnName("shop_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.ShopComments)
                    .IsRequired()
                    .HasColumnName("shop_comments")
                    .HasMaxLength(300);

                entity.Property(e => e.ShopDislike).HasColumnName("shop_dislike");

                entity.Property(e => e.ShopLike).HasColumnName("shop_like");

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasColumnName("shop_name")
                    .HasMaxLength(150);

                entity.Property(e => e.ShopRating).HasColumnName("shop_rating");

                entity.Property(e => e.ShopRegDate)
                    .HasColumnName("shop_reg_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShopSlogon)
                    .HasColumnName("shop_slogon")
                    .HasMaxLength(1000);

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Eshop)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("R_57");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Eshop)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("R_58");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.Eshop)
                    .HasForeignKey(d => d.Uid)
                    .HasConstraintName("R_56");
            });

            modelBuilder.Entity<EshopGoodsList>(entity =>
            {
                entity.HasKey(e => new { e.GoodsId, e.ShopId });

                entity.ToTable("eshop_goods_list");

                entity.Property(e => e.GoodsId).HasColumnName("goods_id");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.GoodsCategoryId).HasColumnName("goods_category_id");

                entity.Property(e => e.GoodsDescription)
                    .HasColumnName("goods_description")
                    .HasMaxLength(300);

                entity.Property(e => e.GoodsName)
                    .HasColumnName("goods_name")
                    .HasMaxLength(300);

                entity.Property(e => e.GoodsPrice).HasColumnName("goods_price");

                entity.HasOne(d => d.GoodsCategory)
                    .WithMany(p => p.EshopGoodsList)
                    .HasForeignKey(d => d.GoodsCategoryId)
                    .HasConstraintName("R_68");

                entity.HasOne(d => d.Shop)
                    .WithMany(p => p.EshopGoodsList)
                    .HasForeignKey(d => d.ShopId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_70");
            });

            modelBuilder.Entity<GoodsCategoryList>(entity =>
            {
                entity.HasKey(e => e.GoodsCategoryId);

                entity.ToTable("goods_category_list");

                entity.Property(e => e.GoodsCategoryId)
                    .HasColumnName("goods_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<GoodsPhotoId>(entity =>
            {
                entity.HasKey(e => e.GoodsPhotoId1);

                entity.ToTable("goods_photo_id");

                entity.Property(e => e.GoodsPhotoId1)
                    .HasColumnName("goods_photo_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GoodsId).HasColumnName("goods_id");

                entity.Property(e => e.PhotoComments)
                    .HasColumnName("photo_comments")
                    .HasMaxLength(300);

                entity.Property(e => e.PhotoPath)
                    .HasColumnName("photo_path")
                    .HasMaxLength(150);

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.HasOne(d => d.EshopGoodsList)
                    .WithMany(p => p.GoodsPhotoId)
                    .HasForeignKey(d => new { d.GoodsId, d.ShopId })
                    .HasConstraintName("R_69");
            });

            modelBuilder.Entity<GoodsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("goods_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GoodsId).HasColumnName("goods_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.GoodsTag)
                    .HasForeignKey<GoodsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_62");
            });

            modelBuilder.Entity<LanguageList>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("language_list");

                entity.Property(e => e.LanguageId)
                    .HasColumnName("language_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasColumnName("language")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<LikeDislikeList>(entity =>
            {
                entity.HasKey(e => new { e.LdId, e.Uid });

                entity.ToTable("like_dislike_list");

                entity.Property(e => e.LdId).HasColumnName("ld_id");

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.Property(e => e.AuctioneerId).HasColumnName("auctioneer_id");

                entity.Property(e => e.BlogPostCommentsId).HasColumnName("blog_post_comments_id");

                entity.Property(e => e.BlogPostId).HasColumnName("blog_post_id");

                entity.Property(e => e.ChatId).HasColumnName("chat_id");

                entity.Property(e => e.CommentsAdAd).HasColumnName("comments_ad_ad");

                entity.Property(e => e.CommentsNewsId).HasColumnName("comments_news_id");

                entity.Property(e => e.CommentsPlacesId).HasColumnName("comments_places_id");

                entity.Property(e => e.CommentsPosterId).HasColumnName("comments_poster_id");

                entity.Property(e => e.GoodsId).HasColumnName("goods_id");

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.Property(e => e.PlacesId).HasColumnName("places_id");

                entity.Property(e => e.PosterId).HasColumnName("poster_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserUseId).HasColumnName("user_use_id");

                entity.HasOne(d => d.U)
                    .WithMany(p => p.LikeDislikeList)
                    .HasForeignKey(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_72");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.ToTable("news");

                entity.Property(e => e.NewsId)
                    .HasColumnName("news_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.NewsBody)
                    .IsRequired()
                    .HasColumnName("news_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.NewsCategoryId).HasColumnName("news_category_id");

                entity.Property(e => e.NewsDate)
                    .HasColumnName("news_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NewsDislike).HasColumnName("news_dislike");

                entity.Property(e => e.NewsLike).HasColumnName("news_like");

                entity.Property(e => e.NewsRating).HasColumnName("news_rating");

                entity.Property(e => e.NewsTeme)
                    .IsRequired()
                    .HasColumnName("news_teme")
                    .HasMaxLength(150);

                entity.Property(e => e.Uid).HasColumnName("uid");

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

                entity.ToTable("news_category_list");

                entity.Property(e => e.NewsCategoryId)
                    .HasColumnName("news_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<NewsTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("news_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NewsId).HasColumnName("news_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.NewsTag)
                    .HasForeignKey<NewsTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_34");
            });

            modelBuilder.Entity<OnlineList>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("online_list");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.UserGuid).HasColumnName("user_guid");

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
                entity.ToTable("places");

                entity.Property(e => e.PlacesId)
                    .HasColumnName("places_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.PlacesBody)
                    .IsRequired()
                    .HasColumnName("places_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.PlacesCategoryId).HasColumnName("places_category_id");

                entity.Property(e => e.PlacesDate)
                    .HasColumnName("places_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlacesDislike).HasColumnName("places_dislike");

                entity.Property(e => e.PlacesLike).HasColumnName("places_like");

                entity.Property(e => e.PlacesRating).HasColumnName("places_rating");

                entity.Property(e => e.PlacesStartDate)
                    .HasColumnName("places_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlacesTema)
                    .IsRequired()
                    .HasColumnName("places_tema")
                    .HasMaxLength(150);

                entity.Property(e => e.Uid).HasColumnName("uid");

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

                entity.ToTable("places_category_list");

                entity.Property(e => e.PlacesCategoryId)
                    .HasColumnName("places_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PlacesTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("places_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PlacesId).HasColumnName("places_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.PlacesTag)
                    .HasForeignKey<PlacesTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_33");
            });

            modelBuilder.Entity<Poster>(entity =>
            {
                entity.ToTable("poster");

                entity.Property(e => e.PosterId)
                    .HasColumnName("poster_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.PosterBody)
                    .IsRequired()
                    .HasColumnName("poster_body")
                    .HasMaxLength(3800);

                entity.Property(e => e.PosterCategoryId).HasColumnName("poster_category_id");

                entity.Property(e => e.PosterDate)
                    .HasColumnName("poster_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosterDislike).HasColumnName("poster_dislike");

                entity.Property(e => e.PosterLike).HasColumnName("poster_like");

                entity.Property(e => e.PosterRating).HasColumnName("poster_rating");

                entity.Property(e => e.PosterStartDate)
                    .HasColumnName("poster_start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosterTema)
                    .IsRequired()
                    .HasColumnName("poster_tema")
                    .HasMaxLength(150);

                entity.Property(e => e.Uid).HasColumnName("uid");

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

                entity.ToTable("poster_category_list");

                entity.Property(e => e.PosterCategoryId)
                    .HasColumnName("poster_category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("category")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<PosterTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("poster_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosterId).HasColumnName("poster_id");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.PosterTag)
                    .HasForeignKey<PosterTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_32");
            });

            modelBuilder.Entity<SexList>(entity =>
            {
                entity.HasKey(e => e.SexId);

                entity.ToTable("sex_list");

                entity.Property(e => e.SexId)
                    .HasColumnName("sex_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SkinList>(entity =>
            {
                entity.HasKey(e => e.SkinId);

                entity.ToTable("skin_list");

                entity.Property(e => e.SkinId)
                    .HasColumnName("skin_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkinName)
                    .IsRequired()
                    .HasColumnName("skin_name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<StatusList>(entity =>
            {
                entity.HasKey(e => e.StatusId);

                entity.ToTable("status_list");

                entity.Property(e => e.StatusId)
                    .HasColumnName("status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SysMessage>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("sys_message");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.MessDate)
                    .HasColumnName("mess_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(200);

                entity.HasOne(d => d.U)
                    .WithOne(p => p.SysMessage)
                    .HasForeignKey<SysMessage>(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_67");
            });

            modelBuilder.Entity<TagList>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("tag_list");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdCount).HasColumnName("ad_count");

                entity.Property(e => e.AuctioneerCount).HasColumnName("auctioneer_count");

                entity.Property(e => e.BlogPostCommentsCount).HasColumnName("blog_post_comments_count");

                entity.Property(e => e.BlogPostCount).HasColumnName("blog_post_count");

                entity.Property(e => e.ChatCount).HasColumnName("chat_count");

                entity.Property(e => e.CommentsAdCount).HasColumnName("comments_ad_count");

                entity.Property(e => e.CommentsNewsCount).HasColumnName("comments_news_count");

                entity.Property(e => e.CommentsPlacesCount).HasColumnName("comments_places_count");

                entity.Property(e => e.CommentsPosterCount).HasColumnName("comments_poster_count");

                entity.Property(e => e.GoodsCount).HasColumnName("goods_count");

                entity.Property(e => e.NewsCount).HasColumnName("news_count");

                entity.Property(e => e.PlacesCount).HasColumnName("places_count");

                entity.Property(e => e.PosterCount).HasColumnName("poster_count");

                entity.Property(e => e.TagName)
                    .IsRequired()
                    .HasColumnName("tag_name")
                    .HasMaxLength(200);

                entity.Property(e => e.UserCount).HasColumnName("user_count");

                entity.Property(e => e.UserUseCount).HasColumnName("user_use_count");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Uid);

                entity.ToTable("users");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.SexId).HasColumnName("sex_id");

                entity.Property(e => e.UserAvator)
                    .HasColumnName("user_avator")
                    .HasMaxLength(100);

                entity.Property(e => e.UserBonusCount).HasColumnName("user_bonus_count");

                entity.Property(e => e.UserDateOfBirth)
                    .HasColumnName("user_date_of_birth")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserDislike).HasColumnName("user_dislike");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("user_email")
                    .HasMaxLength(100);

                entity.Property(e => e.UserFirstname)
                    .IsRequired()
                    .HasColumnName("user_firstname")
                    .HasMaxLength(100);

                entity.Property(e => e.UserLastOnline)
                    .HasColumnName("user_last_online")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserLastname)
                    .IsRequired()
                    .HasColumnName("user_lastname")
                    .HasMaxLength(100);

                entity.Property(e => e.UserLike).HasColumnName("user_like");

                entity.Property(e => e.UserLoc)
                    .HasColumnName("user_loc")
                    .HasMaxLength(20);

                entity.Property(e => e.UserLogFile)
                    .HasColumnName("user_log_file")
                    .HasColumnType("xml");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("user_name")
                    .HasMaxLength(50);

                entity.Property(e => e.UserNikname)
                    .IsRequired()
                    .HasColumnName("user_nikname")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasColumnName("user_password")
                    .HasMaxLength(100);

                entity.Property(e => e.UserPasswordHistory)
                    .HasColumnName("user_password_history")
                    .HasColumnType("xml");

                entity.Property(e => e.UserPremium)
                    .HasColumnName("user_premium")
                    .HasMaxLength(1);

                entity.Property(e => e.UserRating).HasColumnName("user_rating");

                entity.Property(e => e.UserRegDate)
                    .HasColumnName("user_reg_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserSlogon)
                    .HasColumnName("user_slogon")
                    .HasMaxLength(300);

                entity.Property(e => e.UserTel)
                    .IsRequired()
                    .HasColumnName("user_tel")
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

                entity.ToTable("user_settings");

                entity.Property(e => e.Uid)
                    .HasColumnName("uid")
                    .ValueGeneratedNever();

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.SkinId).HasColumnName("skin_id");

                entity.Property(e => e.UserGpsLoc)
                    .HasColumnName("user_gps_loc")
                    .HasMaxLength(1);

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.UserSettings)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("R_149");

                entity.HasOne(d => d.Skin)
                    .WithMany(p => p.UserSettings)
                    .HasForeignKey(d => d.SkinId)
                    .HasConstraintName("R_150");

                entity.HasOne(d => d.U)
                    .WithOne(p => p.UserSettings)
                    .HasForeignKey<UserSettings>(d => d.Uid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_55");
            });

            modelBuilder.Entity<UserTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("user_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.UserTag)
                    .HasForeignKey<UserTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_30");
            });

            modelBuilder.Entity<UserUseTag>(entity =>
            {
                entity.HasKey(e => e.TagId);

                entity.ToTable("user_use_tag");

                entity.Property(e => e.TagId)
                    .HasColumnName("tag_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Uid).HasColumnName("uid");

                entity.HasOne(d => d.Tag)
                    .WithOne(p => p.UserUseTag)
                    .HasForeignKey<UserUseTag>(d => d.TagId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("R_35");
            });
        }
    }
}
