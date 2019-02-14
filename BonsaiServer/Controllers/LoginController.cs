using System;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using BonsaiServer.Model;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        public LoginController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpPost]
        public IActionResult Index([FromBody]Credentials cred)
        {
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                var sql = $"SELECT password FROM users WHERE login = '{cred.login}'";
                bool success; 
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                rdr.Read();
                success = rdr.HasRows && rdr.GetString(0) == cred.password;
                rdr.Close();
                if(success) return Ok("Logged in as " + cred.login);
                else return BadRequest("Wrong login or password.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.ToString()); 
            }
            finally
            {
                conn.Close();
            }
        }
    }
}