using System.Data.Entity;

namespace MyApp.Models
{
    public class MyAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}