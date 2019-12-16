namespace HPIT.FL
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

        public virtual DbSet<buy> buy { get; set; }
        public virtual DbSet<fenlei> fenlei { get; set; }
        public virtual DbSet<xinxi> xinxi { get; set; }
        public virtual DbSet<yonghu> yonghu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<buy>()
                .Property(e => e.datedays)
                .IsUnicode(false);

            modelBuilder.Entity<fenlei>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<fenlei>()
                .HasMany(e => e.xinxi)
                .WithOptional(e => e.fenlei)
                .HasForeignKey(e => e.fid);

            modelBuilder.Entity<xinxi>()
                .Property(e => e.fname)
                .IsUnicode(false);

            modelBuilder.Entity<xinxi>()
                .Property(e => e.indurtuds)
                .IsUnicode(false);

            modelBuilder.Entity<xinxi>()
                .HasMany(e => e.buy)
                .WithOptional(e => e.xinxi)
                .HasForeignKey(e => e.hid);

            modelBuilder.Entity<yonghu>()
                .Property(e => e.yong)
                .IsUnicode(false);
        }
    }
}
