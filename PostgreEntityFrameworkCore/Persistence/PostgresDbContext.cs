using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreEntityFrameworkCore.Persistence
{
    public class PostgresDbContext : DemoDbContext
    {
        private readonly IConfiguration config;
        public PostgresDbContext(DbContextOptions options, IConfiguration cg) : base(options)
        {
            config = cg;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(config.GetConnectionString("Default"), b => b.MigrationsAssembly(typeof(PostgresDbContext).Assembly.FullName));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

            base.OnModelCreating(modelBuilder);
        }
    }
}
