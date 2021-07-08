using BlazorProductStore.Shared.Models;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BlazorProductStore.Server.Models
{
    public partial class TestProductDbContext : DbContext
    {
        public TestProductDbContext()
        {
        }

        public TestProductDbContext(DbContextOptions<TestProductDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cartline> Cartlines { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasCharSet("utf8")
                .UseCollation("utf8_general_ci");

            modelBuilder.Entity<Cartline>(entity =>
            {
                entity.ToTable("cartline");

                entity.HasIndex(e => e.OrderId, "fk_CartLine_Order1_idx");

                //entity.HasIndex(e => e.ProductId, "fk_CartLine_Product_idx");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.OrderId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Order_Id");

                entity.Property(e => e.ProductId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Product_Id");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Cartlines)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CartLine_Order1");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.Cartlines)
                //    .HasForeignKey(d => d.ProductId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("fk_CartLine_Product");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("order");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.GiftWrap).HasColumnType("tinyint(4)");

                entity.Property(e => e.Shipped).HasColumnType("tinyint(4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.State).HasMaxLength(45);

                entity.Property(e => e.Zip)
                    .HasMaxLength(45)
                    .HasColumnName("ZIP");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("product");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(45);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Price).HasPrecision(8, 2);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
