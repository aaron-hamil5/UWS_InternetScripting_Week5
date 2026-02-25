using System.Dynamic;
using Microsoft.EntityFrameworkCore;

namespace NorthwindContext{
    public class NorthwindDatabase : DbContext{
        public DbSet<Supplier>Suppliers{set; get;}
        public DbSet<Product>Products{set; get;}
        public DbSet<Customer>Customers{set; get;}
        public DbSet<Category>Categories{set; get;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Northwind.db");
        }
    }

}