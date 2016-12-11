namespace Project2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IndianCuisinesContext : DbContext
    {
        public IndianCuisinesContext()
            : base("name=IndianCuisinesConnection")
        {
        }

        public virtual DbSet<Appetizer> Appetizers { get; set; }
        public virtual DbSet<Non_veg_curry> Non_veg_curry { get; set; }
        public virtual DbSet<Vegetration_curry> Vegetration_curry { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Appetizer>()
                .Property(e => e.AppetizerImage)
                .IsFixedLength();

            modelBuilder.Entity<Non_veg_curry>()
                .Property(e => e.Non_vegCurryPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Non_veg_curry>()
                .Property(e => e.Non_vegCurryImage)
                .IsFixedLength();

            modelBuilder.Entity<Vegetration_curry>()
                .Property(e => e.VegetrationCurryDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Vegetration_curry>()
                .Property(e => e.VegetrationCurryPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Vegetration_curry>()
                .Property(e => e.VegetrationCurryImage)
                .IsFixedLength();

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.start_ip_address)
                .IsUnicode(false);

            modelBuilder.Entity<database_firewall_rules>()
                .Property(e => e.end_ip_address)
                .IsUnicode(false);
        }
    }
}
