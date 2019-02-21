using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BonsaiServer.Database
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Mutation> Mutations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            Seed(modelBuilder);
        }

        void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User[]
            {
                new User
                {
                    Id = 1,
                    Login = "a",
                    PasswordHash = "28355A2D1A8636F26EBD23DB7F7BC58F319F8B4D85282DDD308CFC5EEB18031B",
                    Email = "abc@wp.pl",
                    Session = "IsThisWorking?"
                },
                new User
                {
                    Id = 2,
                    Login = "radek",
                    PasswordHash = "450A10FAD8BC1453CF4690E7391F34DF4E7C3621CCC7E1B45699190C6ACC36E4",
                    Email = "radek@example.com",
                    Session = "OtherSessionHash"
                },
            });

            modelBuilder.Entity<Plant>().HasData(PlantSeed(new int[] { 1, 2 }));
            modelBuilder.Entity<Mutation>().HasData(new Mutation()
            {
                Id = 1,
                UserId = 1,
                Plant1Id = 1,
                Plant2Id = 2,
            });
        }

        IEnumerable<Plant> PlantSeed(IEnumerable<int> UserIds)
        {
            List<Plant> result = new List<Plant>();
            int plantId = 1;
            foreach (int userId in UserIds)
            {
                for (int i = 0; i < 5; i++)
                {
                    Plant plant = Plant.RandomPlant();
                    plant.Id = plantId++;
                    plant.UserId = userId;
                    result.Add(plant);
                }
            }
            return result;
        }
    }
}
