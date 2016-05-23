using Microsoft.EntityFrameworkCore;
using POC.Domain;
using POC.Application.Providers;

namespace POC.Infrastructure.EntityFramework
{
    public class DbContext : DbContext, IDbContext
    {
        private readonly IDbConfigurationProvider _configurationProvider;

        public DbContext(IDbConfigurationProvider configurationProvider)
        {
            _configurationProvider = configurationProvider;
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configurationProvider.DatabaseConnectionString);
        }
    }
}
