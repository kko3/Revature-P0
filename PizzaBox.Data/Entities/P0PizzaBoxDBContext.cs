using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzaBox.Data.Entities
{
    public partial class P0PizzaBoxDBContext : DbContext
    {
        public P0PizzaBoxDBContext()
        {
        }

        public P0PizzaBoxDBContext(DbContextOptions<P0PizzaBoxDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Crust> Crust { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Size> Size { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:keilpizza.database.windows.net,1433;Initial Catalog=P0PizzaBoxDB;Persist Security Info=False;User ID=sqladmin;Password=Password12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Crust>(entity =>
            {
                entity.ToTable("Crust", "Pizza");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("numeric(3, 2)");
            });

            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.ToTable("Pizza", "Pizza");

                entity.Property(e => e.Price).HasColumnType("numeric(5, 2)");

                entity.HasOne(d => d.Crust)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.CrustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CrustId");

                entity.HasOne(d => d.Size)
                    .WithMany(p => p.Pizza)
                    .HasForeignKey(d => d.SizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SizeId");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.ToTable("Size", "Pizza");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price).HasColumnType("numeric(3, 2)");
            });
        }
    }
}
