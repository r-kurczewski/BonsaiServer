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
    [Route("[controller]")]
    public class RegisterController : Controller
    {
        private readonly AppSettings _appSettings;
        public RegisterController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpPost]
        public IActionResult Register([FromBody] Credentials cred)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                if (LoginExist(cred.login, conn)) return StatusCode(409, "Login is unavailable.");
                if (EmailExist(cred.email, conn)) return StatusCode(409, "Email is unavailable.");
                var sql = $"INSERT INTO users(login, password, email) VALUES ('{cred.login}', '{cred.password}', '{cred.email}')";
                var cmd = new MySqlCommand(sql, conn);
                var  rdr = cmd.ExecuteNonQuery();
                #region add start plants
                var userID = SQLHelper.GetUserID(cred, conn);
                sql = $@"INSERT INTO plants VALUES 
                        (NULL, '{userID}', 'A', '1', '1', '1', '1', '1', '1', '1', ''), 
                        (NULL, '{userID}', 'B', '2', '2', '1', '2', '2', '2', '2', ''), 
                        (NULL, '{userID}', 'C', '3', '3', '1', '3', '3', '3', '3', '')";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                #endregion
                return Ok($"Account {cred.login} successfully created.");
            }
            catch (MySqlException ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        [Route("check")]
        [HttpPost]
        public IActionResult CheckName([FromBody] Credentials cred)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                if (LoginExist(cred.login, conn))
                    return StatusCode(409, "Login is already used.");
                else
                    return Ok($"Login {cred.login} is available.");
            }
            catch (MySqlException ex)
            {
                return StatusCode(500, ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public bool LoginExist(string login, MySqlConnection conn)
        {
            var result = false;
            var sql = $"SELECT COUNT(*) FROM users WHERE login = '{login}'";
            var cmd = new MySqlCommand(sql, conn);
            var rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0) result = true;
            rdr.Close();
            return result;
        }

        public bool EmailExist(string email, MySqlConnection conn)
        {
            var result = false;
            var sql = $"SELECT COUNT(*) FROM users WHERE email = '{email}'";
            var cmd = new MySqlCommand(sql, conn);
            var rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0) result = true;
            rdr.Close();
            return result;
        }

    }
}