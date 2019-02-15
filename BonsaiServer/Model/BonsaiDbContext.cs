using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    public class BonsaiDbContext : DbContext
    {
        public BonsaiDbContext(DbContextOptions<BonsaiDbContext> options) : base(options)
        {

        }

        public DbSet<Plant> Plants { get; set; }
    }
}
