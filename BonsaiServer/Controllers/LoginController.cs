using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Configuration;
using BonsaiServer.Model;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    [Produces("application/json")]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly AppSettings _appSettings;
        public LoginController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var result = new List<Person>();
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();

                var sql = "SELECT name, surname, age from test";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(new Person(rdr.GetString(0), rdr.GetString(1), rdr.GetInt32(2)));
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            return result;
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [Serializable]
        public class Person
        {
            public string name;
            public string surname;
            public int age;

            public Person(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }
        }


    }
}