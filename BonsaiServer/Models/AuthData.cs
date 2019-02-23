using BonsaiServer.Database;
using System;
namespace BonsaiServer.Models
{
    [Serializable]
    public class AuthData<T>
    {
        public User User { get; set; }
        public T Data { get; set; }

        public AuthData(string session, T data)
        {
            User = new User() { Session = session };
            this.Data = data;
        }

        public AuthData(User user, T data)
        {
            User = user;
            Data = data;
        }
    }
}
