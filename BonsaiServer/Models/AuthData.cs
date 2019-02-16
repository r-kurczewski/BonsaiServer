using BonsaiServer.Database;
using System;
namespace BonsaiServer.Models
{
    [Serializable]
    public class AuthData<T>
    {
        public User cred;
        public T data;

        public AuthData(User cred, T data)
        {
            this.cred = cred;
            this.data = data;
        }
    }
}
