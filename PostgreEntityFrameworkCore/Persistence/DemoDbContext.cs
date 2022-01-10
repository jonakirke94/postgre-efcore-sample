using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PostgreEntityFrameworkCore.Persistence
{
    public abstract class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers => Set<CustomerEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerEntity>().Configure();

            base.OnModelCreating(modelBuilder);
        }
    }
}
