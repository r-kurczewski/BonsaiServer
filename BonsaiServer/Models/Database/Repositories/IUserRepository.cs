using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public interface IUsersRepository
    {
        User GetUserById(int id);

        User GetOwnerOfPlant(Plant plant);

        int GetUserBySession(Session session);

        bool IsLoginUsed(string login);

        bool IsEmailUsed(string email);
    }
}
