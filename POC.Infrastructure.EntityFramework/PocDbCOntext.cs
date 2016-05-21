using Microsoft.EntityFrameworkCore;
using POC.Domain;
using POC.Application.Providers;

namespace POC.Infrastructure.EntityFramework
{
    public class PocDbContext : DbContext
    {
        private readonly IDbConfigurationProvider _configurationProvider;

        public PocDbContext(IDbConfigurationProvider configurationProvider)
        {
            _configurationProvider = configurationProvider;
        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(_configurationProvider.DatabaseConnectionString);
        }
    }
}
