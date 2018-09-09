using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    [Serializable]
    public class Credentials
    {
        public string login;
        public string password;
        public string email;

        public Credentials()
        {

        }

        public Credentials(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public Credentials(string login, string password, string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;
        }
    }

    [Serializable]
    public class AuthData<T>
    {
        public Credentials cred;
        public T data;

        public AuthData(Credentials cred, T data)
        {
            this.cred = cred;
            this.data = data;
        }
    }
}
