namespace ShopV5.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ShopV5.Models;

    public partial class ShopContext : DbContext
    {
        public ShopContext()
            : base("name=MagazinModel")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Seller> Sellers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Order>()
                .Property(e => e.OrdersDate)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<ProductCategory>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.ProductCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .Property(e => e.Characteristics)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Seller>()
                .Property(e => e.Company)
                .IsFixedLength();

            modelBuilder.Entity<Seller>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Seller>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Seller>()
                .HasMany(e => e.Orders)
                .WithRequired(e => e.Seller)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Company)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .Property(e => e.CUI)
                .IsFixedLength();

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Supplier>()
                .HasMany(e => e.Sellers)
                .WithRequired(e => e.Supplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.FullName)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNumber)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<User>()
                .HasMany(e => e.Admins)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Sellers)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
