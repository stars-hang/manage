namespace YZH.Dal
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<CG_Buy> CG_Buy { get; set; }
        public virtual DbSet<CG_Commodity> CG_Commodity { get; set; }
        public virtual DbSet<CG_Detail> CG_Detail { get; set; }
        public virtual DbSet<CG_Imgs> CG_Imgs { get; set; }
        public virtual DbSet<CG_Market> CG_Market { get; set; }
        public virtual DbSet<CG_Mbwt> CG_Mbwt { get; set; }
        public virtual DbSet<CG_Merchants> CG_Merchants { get; set; }
        public virtual DbSet<CG_Project> CG_Project { get; set; }
        public virtual DbSet<CG_Recommend> CG_Recommend { get; set; }
        public virtual DbSet<CG_Rent> CG_Rent { get; set; }
        public virtual DbSet<CG_Shops> CG_Shops { get; set; }
        public virtual DbSet<CG_Staff> CG_Staff { get; set; }
        public virtual DbSet<UserS> UserS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CG_Commodity>()
                .Property(e => e.ComName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Commodity>()
                .Property(e => e.CommDemo)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Imgs>()
                .Property(e => e.ImgUrl)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Imgs>()
                .Property(e => e.ImgTableName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Imgs>()
                .Property(e => e.ImgTableID)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Market>()
                .Property(e => e.MarketSeat)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Mbwt>()
                .Property(e => e.UserMBWT)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.MerName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.ShopName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.MerPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.MerHome)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.MerCardID)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.MerBrand)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Merchants>()
                .Property(e => e.MerType)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Project>()
                .Property(e => e.ProBusiness)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Project>()
                .Property(e => e.ManageID)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Recommend>()
                .Property(e => e.RecomName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Recommend>()
                .Property(e => e.RecomDemo)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Rent>()
                .Property(e => e.RentName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Rent>()
                .Property(e => e.RentEnd)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Rent>()
                .Property(e => e.RentAndInclude)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Rent>()
                .Property(e => e.RentAccIncome)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Rent>()
                .Property(e => e.RentDiversity)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Rent>()
                .Property(e => e.Demo)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Rent>()
                .Property(e => e.RentType)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Shops>()
                .Property(e => e.ShopName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Shops>()
                .Property(e => e.ShopSeat)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Staff>()
                .Property(e => e.StaffName)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Staff>()
                .Property(e => e.StaffPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Staff>()
                .Property(e => e.StaffHome)
                .IsUnicode(false);

            modelBuilder.Entity<CG_Staff>()
                .Property(e => e.StaffCardID)
                .IsUnicode(false);

            modelBuilder.Entity<UserS>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserS>()
                .Property(e => e.UserPwd)
                .IsUnicode(false);

            modelBuilder.Entity<UserS>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserS>()
                .Property(e => e.UserMiMa)
                .IsUnicode(false);

            modelBuilder.Entity<UserS>()
                .Property(e => e.phone)
                .IsUnicode(false);
        }
    }
}
