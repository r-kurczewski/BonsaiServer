using BonsaiServer.Database;
using System;
namespace BonsaiServer.Models
{
    [Serializable]
    public class AuthData<T>
    {
        public string Session { get; set; }
        public User User { get; set; }
        public T Data { get; set; }

        public AuthData(string session, T data)
        {
            Session = session;
            Data = data;
        }

        public AuthData(User user, T data)
        {
            Session = user.Session;
            Data = data;
        }
    }
}
