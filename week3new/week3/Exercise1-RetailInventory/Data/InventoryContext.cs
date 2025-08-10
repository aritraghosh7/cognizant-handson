using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=RetailInventoryDB;Trusted_Connection=True;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Electronics" },
                new Category { CategoryId = 2, Name = "Clothing" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Laptop", Stock = 10, CategoryId = 1 },
                new Product { ProductId = 2, Name = "T-Shirt", Stock = 50, CategoryId = 2 }
            );
        }
    }
}
