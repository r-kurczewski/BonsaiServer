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
            return Ok("Bonsai REST Server is ready.");
        }


    [HttpGet("test/{userID}/{plantID}")]
    public IActionResult Test(int userID, int plantID)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            conn.Open();
            var result = SQLHelper.IsUserPlant(userID, plantID, conn);
            conn.Close();
            return Ok(result);
        }
    }
}
