using System.Data.Entity;

namespace WebApplication1.Models
{
    public class CreditContext : DbContext
    {
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Bid> Bids { get; set; }
    }
}