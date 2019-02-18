using BonsaiServer.Database;
using System;
namespace BonsaiServer.Models
{
    [Serializable]
    public class AuthData<T>
    {
        public string session;
        public T data;

        public AuthData(string session, T data)
        {
            this.session = session;
            this.data = data;
        }
    }
}
