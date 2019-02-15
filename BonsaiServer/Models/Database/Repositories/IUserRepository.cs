using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public interface IUserRepository
    {
        UserCredentials GetUserById(int id);

        UserCredentials GetOwnerOfPlant(Plant plant);

        bool IsLoginUsed(string login);

        bool IsEmailUsed(string email);
    }
}
