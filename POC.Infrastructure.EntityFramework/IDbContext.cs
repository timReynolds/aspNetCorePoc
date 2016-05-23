using Microsoft.EntityFrameworkCore;

namespace POC.Infrastructure.EntityFramework
{
    public interface IDbContext
    {
        DbSet<Person> Persons { get; }
        DbSet<Team> Teams { get; }
    }
}