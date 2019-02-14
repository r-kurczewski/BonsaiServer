using BonsaiServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace BonsaiServer.Controllers
{
    public class HomeController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        public HomeController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult Index()
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
            return Ok($"Bonsai Server: {_appSettings.Environment}\nSQL Server: {sqlConnection}");
        }
    }
}
