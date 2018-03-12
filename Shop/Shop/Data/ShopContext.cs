using Shop.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {

        }
        public ShopContext()
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategory");
            modelBuilder.Entity<Address>().ToTable("Address");

            modelBuilder.Entity<Address>()
                .HasKey(a => a.UserId);
            modelBuilder.Entity<ProductCategory>()
                .HasKey(p => p.ProductId);
            //One to one User -> Address
            modelBuilder.Entity<User>()
                .HasOne(u => u.Address)
                .WithOne(ad => ad.User)
                .HasForeignKey<Address>(ad => ad.UserId);

            //One to one Product -> ProductCategory
            /*modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductCategory)
                .WithOne(c => c.Product)
                .HasForeignKey<ProductCategory>(c => c.ProductId);*/

            //One to many Product->ProductCategory
            modelBuilder.Entity<Product>()
                .HasOne(p => p.ProductCategory)
                .WithMany(c => c.Products)
                .HasForeignKey<ProductCategory>(p =>p.Id);


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.ConnectionString);
        }


    }
}
