using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
    public class ShopContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = LAB1504-16\\SQLEXPRESS;Initial Catalog = ShopDB;User Id = user01;Password = 12345678; trustservercertificate=True");
        }

    }
}
