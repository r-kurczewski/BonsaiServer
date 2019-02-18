
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

        public User GetOwnerOfPlant(Plant plant)
        {
            return context.Users.Find(plant.User);
        }


        public User GetUserById(int id)
        {
            return context.Users.Find(id);
        }

        public void RegisterUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool IsEmailUsed(string email)
        {
            return !context.Users.FirstOrDefault(s => s.Email == email).Equals(null);
        }

        public bool IsLoginUsed(string login)
        {
            return !context.Users.FirstOrDefault(s => s.Login == login).Equals(null);
        }

        public User GetUserBySession(string session)
        {
            return context.Users.FirstOrDefault(s => s.Session == session);
        }

        public User GetUserByCredentials(string login, string passwordHash)
        {
            return context.Users.FirstOrDefault(s => s.Login == login && s.PasswordHash == passwordHash);
        }
    }
}
