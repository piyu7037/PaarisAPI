using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PaarisAPI.Models;

public partial class PaarisDbContext : DbContext
{
    public PaarisDbContext()
    {
    }

    public PaarisDbContext(DbContextOptions<PaarisDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductsOrder> ProductsOrders { get; set; }

    public virtual DbSet<SettingFile> SettingFiles { get; set; }

    public virtual DbSet<UsersLogin> UsersLogins { get; set; }

    public virtual DbSet<UsersPermissionsRole> UsersPermissionsRoles { get; set; }

    public virtual DbSet<UsersPermissionsUser> UsersPermissionsUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LTPU-5CG8161LV8\\SQLEXPRESS;Database=paarisDB;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_pkey");

            entity.ToTable("orders");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Fullname)
                .HasMaxLength(50)
                .HasColumnName("fullname");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Payment)
                .HasMaxLength(50)
                .HasColumnName("payment");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Productid).HasColumnName("productid");
            entity.Property(e => e.PublishedAt)
                .HasColumnType("datetime")
                .HasColumnName("published_at");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TotalPrice).HasColumnName("totalPrice");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.UsersPermissionsUser).HasColumnName("users_permissions_user");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("products_pkey");

            entity.ToTable("products");

            entity.HasIndex(e => e.Slug, "products_slug_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AddInfo)
                .HasMaxLength(50)
                .HasColumnName("addInfo");
            entity.Property(e => e.BestSelling).HasColumnName("bestSelling");
            entity.Property(e => e.BestSellingProducts).HasColumnName("bestSellingProducts");
            entity.Property(e => e.Category).HasColumnName("category");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.CurrencyType)
                .HasMaxLength(50)
                .HasColumnName("currencyType");
            entity.Property(e => e.CurrentPrice).HasColumnName("currentPrice");
            entity.Property(e => e.Hot).HasColumnName("hot");
            entity.Property(e => e.ImageUrl)
                .HasColumnType("image")
                .HasColumnName("imageUrl");
            entity.Property(e => e.InStock).HasColumnName("inStock");
            entity.Property(e => e.Locale)
                .HasMaxLength(50)
                .HasColumnName("locale");
            entity.Property(e => e.LongDesc).HasMaxLength(500);
            entity.Property(e => e.NewArrival).HasColumnName("newArrival");
            entity.Property(e => e.NewArrivalProducts).HasColumnName("newArrivalProducts");
            entity.Property(e => e.OldPrice).HasColumnName("oldPrice");
            entity.Property(e => e.OnSell).HasColumnName("onSell");
            entity.Property(e => e.OutOfStock).HasColumnName("outOfStock");
            entity.Property(e => e.PublishedAt)
                .HasColumnType("datetime")
                .HasColumnName("published_at");
            entity.Property(e => e.ShortDesc)
                .HasMaxLength(200)
                .HasColumnName("shortDesc");
            entity.Property(e => e.Sku)
                .HasMaxLength(50)
                .HasColumnName("sku");
            entity.Property(e => e.Slug)
                .HasMaxLength(10)
                .HasColumnName("slug");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Vendor)
                .HasMaxLength(50)
                .HasColumnName("vendor");
        });

        modelBuilder.Entity<ProductsOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("orders_products__products_orders_pkey");

            entity.ToTable("products_orders");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.OrderId).HasColumnName("order_id");
            entity.Property(e => e.ProductId).HasColumnName("product_id");
        });

        modelBuilder.Entity<SettingFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("settingFile");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.FileName)
                .HasMaxLength(50)
                .HasColumnName("fileName");
        });

        modelBuilder.Entity<UsersLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("usersLogin");

            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("emailId");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("role");
            entity.Property(e => e.Userid)
                .ValueGeneratedOnAdd()
                .HasColumnName("userid");
        });

        modelBuilder.Entity<UsersPermissionsRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users-permissions_role_pkey");

            entity.ToTable("users_permissions_role");

            entity.HasIndex(e => e.Type, "users-permissions_role_type_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .HasColumnName("name");
            entity.Property(e => e.Type)
                .HasMaxLength(250)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
        });

        modelBuilder.Entity<UsersPermissionsUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("users-permissions_user_pkey");

            entity.ToTable("users-permissions_user");

            entity.HasIndex(e => e.Username, "users-permissions_user_username_unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Blocked).HasColumnName("blocked");
            entity.Property(e => e.ConfirmationToken)
                .HasMaxLength(50)
                .HasColumnName("confirmationToken");
            entity.Property(e => e.Confirmed).HasColumnName("confirmed");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.CreatedBy).HasColumnName("created_by");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Provider)
                .HasMaxLength(50)
                .HasColumnName("provider");
            entity.Property(e => e.ResetPasswordToken)
                .HasMaxLength(50)
                .HasColumnName("resetPasswordToken");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.UpdatedBy).HasColumnName("updated_by");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
