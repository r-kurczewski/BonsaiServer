
using BonsaiServer.Models;
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

        public void AddUser(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
        }

        public bool IsEmailUsed(string email)
        {
            return context.Users.FirstOrDefault(s => s.Email == email) != null;
        }

        public bool IsLoginUsed(string login)
        {
            return context.Users.FirstOrDefault(s => s.Login == login) != null;
        }

        public User GetUserBySession(string session)
        {
            return context.Users.FirstOrDefault(s => s.Session == session);
        }

        public User GetUserByCredentials(string login, string passwordHash)
        {
            return context.Users.FirstOrDefault(s => s.Login == login && s.PasswordHash == passwordHash);
        }

        public string SetNewSession(User user)
        {
            string session;
            int i = 0;
            do
            {
                session = Security.Sha256Hash(DateTime.Now.ToString() + i++);
            } while (context.Users.FirstOrDefault(s => s.Session == session) != null);
            user.Session = session;
            context.Users.Find(user.Id).Session = session;
            context.SaveChanges();
            return session;
        }
    }
}
