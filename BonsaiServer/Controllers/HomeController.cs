using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace BonsaiServer.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;
        public HomeController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult Home()
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            string sqlConnection;
            try
            {
                conn.Open();
                sqlConnection = "OK";

            }
            catch(MySqlException ex)
            {
                sqlConnection = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return Ok($"Bonsai Server: OK\nSQL Server: {sqlConnection}");
        }
    }
}
