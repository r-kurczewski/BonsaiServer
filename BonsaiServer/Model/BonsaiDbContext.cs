using Microsoft.EntityFrameworkCore;

namespace BonsaiServer.Model
{
    public class BonsaiDbContext : DbContext
    {
        public BonsaiDbContext(DbContextOptions<BonsaiDbContext> options) : base(options)
        {

        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
