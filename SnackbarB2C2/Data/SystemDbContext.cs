using SnackbarB2C2Library;
using Microsoft.EntityFrameworkCore;

namespace SnackbarB2C2.Data
{
    public class SystemDbContext : DbContext
    {
        // All classes for the database
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Owner> Owners { get; set; }

        // The rest of the database inheritence
        public SystemDbContext(DbContextOptions<SystemDbContext> contextOptions) : base(contextOptions) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); 
        }
    }
}
