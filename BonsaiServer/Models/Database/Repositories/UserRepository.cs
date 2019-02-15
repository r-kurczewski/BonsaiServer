using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;

        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }

        public UserCredentials GetOwnerOfPlant(Plant plant)
        {
            return context.Users.Find(plant.UserId);
        }

        public UserCredentials GetUserById(int id)
        {
            return context.Users.Find(id);
        }

        public bool IsEmailUsed(string email)
        {
            return !context.Users.FirstOrDefault(s => s.Email == email).Equals(null);
        }

        public bool IsLoginUsed(string login)
        {
            return !context.Users.FirstOrDefault(s => s.Login == login).Equals(null);
        }
    }
}
