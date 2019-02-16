﻿using Microsoft.EntityFrameworkCore;

namespace BonsaiServer.Database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Mutation> Mutations { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
