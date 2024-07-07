using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NowSaiGon.ViewModels;

#nullable disable

namespace NowSaiGon.Models
{
    public partial class lvVietNamContext : DbContext
    {
        public lvVietNamContext()
        {
        }

        public lvVietNamContext(DbContextOptions<lvVietNamContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblContact> TblContacts { get; set; }
        public virtual DbSet<TblCustomer> TblCustomers { get; set; }
        public virtual DbSet<TblOrder> TblOrders { get; set; }
        public virtual DbSet<TblOrderDetail> TblOrderDetails { get; set; }
        public virtual DbSet<TblProduct> TblProducts { get; set; }
        public virtual DbSet<TblProductDetail> TblProductDetails { get; set; }
        public virtual DbSet<TblProductImage> TblProductImages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=ADMIN-PC\\SQLEXPRESS; Initial Catalog=lvVietNam; Integrated Security=true; uid=sa;password=12345678");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.ToTable("tbl_Category");

                entity.Property(e => e.CatName).HasMaxLength(150);

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.ModifierDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblContact>(entity =>
            {
                entity.HasKey(e => e.ConId);

                entity.ToTable("tbl_Contact");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.ModifierDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.Website).HasMaxLength(150);
            });

            modelBuilder.Entity<TblCustomer>(entity =>
            {
                entity.HasKey(e => e.CusId);

                entity.ToTable("tbl_Customer");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CustomerName).HasMaxLength(150);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Pass).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(15);
            });

            modelBuilder.Entity<TblOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("tbl_Order");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(150);

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.ModifierDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.ToltalAmount).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.TblOrders)
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK_tbl_Order_tbl_Customer");
            });

            modelBuilder.Entity<TblOrderDetail>(entity =>
            {
                entity.HasKey(e => e.OdeId);

                entity.ToTable("tbl_OrderDetail");

                entity.Property(e => e.OdeId).HasColumnName("ODeId");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_tbl_OrderDetail_tbl_Order");

                entity.HasOne(d => d.ProDe)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.ProDeId)
                    .HasConstraintName("FK_tbl_OrderDetail_tbl_ProductDetail");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TblOrderDetails)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK_tbl_OrderDetail_tbl_Product");
            });

            modelBuilder.Entity<TblProduct>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.ToTable("tbl_Product");

                entity.Property(e => e.Avatar).HasMaxLength(500);

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Decription).HasMaxLength(4000);

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.ModifierDate).HasColumnType("datetime");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PriceSale).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProName).HasMaxLength(150);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblProducts)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_tbl_Product_tbl_Category");
            });

            modelBuilder.Entity<TblProductDetail>(entity =>
            {
                entity.HasKey(e => e.ProDeId);

                entity.ToTable("tbl_ProductDetail");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.ModifierDate).HasColumnType("datetime");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TblProductDetails)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK_tbl_ProductDetail_tbl_Product");
            });

            modelBuilder.Entity<TblProductImage>(entity =>
            {
                entity.HasKey(e => e.ImgId);

                entity.ToTable("tbl_ProductImages");

                entity.Property(e => e.CreatedBy).HasMaxLength(150);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Image).HasMaxLength(500);

                entity.Property(e => e.ModifierBy).HasMaxLength(150);

                entity.Property(e => e.ModifierDate).HasColumnType("datetime");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.TblProductImages)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK_tbl_ProductImages_tbl_Product");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public DbSet<NowSaiGon.ViewModels.RegisterViewModel> RegisterViewModel { get; set; }
    }
}
