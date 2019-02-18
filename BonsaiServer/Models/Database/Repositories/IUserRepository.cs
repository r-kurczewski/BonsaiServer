using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public interface IUserRepository
    {
        User GetUserById(int id);

        User GetOwnerOfPlant(Plant plant);

        User GetUserBySession(string session);

        void RegisterUser(User user);

        bool IsLoginUsed(string login);

        bool IsEmailUsed(string email);

        User GetUserByCredentials(string login, string passwordHash);
    }
}
