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
                    PasswordHash = "28355a2d1a8636f26ebd23db7f7bc58f319f8b4d85282ddd308cfc5eeb18031b",
                    Email = "abc@wp.pl",
                    Session = "c8f0cbf67674c562415f802542e9e384ca056af3b8f2756acbfa7b0cfeeb6a95"
                },
                new User
                {
                    Id = 2,
                    Login = "radek",
                    PasswordHash = "450a10fad8bc1453cf4690e7391f34df4e7c3621ccc7e1b45699190c6acc36e4",
                    Email = "radek@example.com",
                    Session = "450a10fad8bc1453cf4690e7391f34df4e7c3621ccc7e1b45699190c6acc36e4"
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
                    plant.Slot = (byte)(i+1);
                    result.Add(plant);
                }
            }
            return result;
        }
    }
}
