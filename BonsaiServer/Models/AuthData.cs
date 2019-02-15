using BonsaiServer.Database;
using System;
namespace BonsaiServer.Models
{
    [Serializable]
    public class AuthData<T>
    {
        public UserCredentials cred;
        public T data;

        public AuthData(UserCredentials cred, T data)
        {
            this.cred = cred;
            this.data = data;
        }
    }
}
