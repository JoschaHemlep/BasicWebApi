using Microsoft.EntityFrameworkCore;

namespace DbAccess
{
    public class DbContextFactory
    {
        private readonly DbContextOptions options;

        public DbContextFactory(DbContextOptions options)
        {
            this.options = options;
        }

        public DatabaseContext Create() => new DatabaseContext(options);

    }
}
