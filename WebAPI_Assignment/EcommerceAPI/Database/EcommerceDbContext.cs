using Microsoft.EntityFrameworkCore;
using EcommerceAPI.Entities;

namespace EcommerceAPI.Database
{
    public class EcommerceDbContext : DbContext
    {
        public DbSet<Product> ProductList { get; set; }
        public DbSet<Order> OrderList { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=EcommerceDB;Trusted_Connection=True;");
        }
    }
}
