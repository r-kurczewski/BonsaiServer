using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using BonsaiServer.Models;
using Microsoft.Extensions.Options;
using BonsaiServer.Database;

namespace BonsaiServer.Controllers
{
    public class RegisterController : ControllerBase
    {
        //private readonly AppSettings _appSettings;
        //public RegisterController(IOptions<AppSettings> appSettings)
        //{
        //    _appSettings = appSettings.Value;
        //}

        //[HttpPost]
        //public IActionResult Index([FromBody] Credentials cred)
        //{
        //    var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        if (UserRepository.LoginExist(cred.login, conn)) return StatusCode(409, "Login is unavailable.");
        //        if (UserRepository.EmailExist(cred.email, conn)) return StatusCode(409, "Email is unavailable.");
        //        var sql = $"INSERT INTO users(login, password, email) VALUES ('{cred.login}', '{cred.password}', '{cred.email}')";
        //        var cmd = new MySqlCommand(sql, conn);
        //        var  rdr = cmd.ExecuteNonQuery();
        //        #region start plants
        //        var userID = UserRepository.GetUserID(cred, conn);
        //        sql = $@"INSERT INTO plants(`userID`, `name`, `leaves_id`, `flower_id`, `leaves_color`, `flower_color`, `stalk_color`, `pot_color`, `dirt_color`, `rarity`, `slot`) VALUES
        //                 ('{userID}', 'Red', '1', '1', 'f11', 'f11', 'f11', 'f95', 'f11', '5', '1'),
        //                 ('{userID}', 'Green', '1', '2', '1f1', '1f1', '1f1', 'f95', '1f1', '1', '2'),
        //                 ('{userID}', 'Blue', '1', '3', '11f', '11f', '11f', 'f95', '11f', '4', '3'),
        //                 ('{userID}', 'Example', '1', '1', '9f1', '13d', '3b1', 'f95', '531', '5', '4');
        //                 ";
        //        cmd = new MySqlCommand(sql, conn);
        //        cmd.ExecuteNonQuery();
        //        #endregion
        //        #region start curency
        //        var startGold = 100;
        //        var startGems = 10;
        //        sql = $"INSERT INTO currencies(userID, gold, gems) VALUES ({userID}, {startGold}, {startGems})";
        //        cmd = new MySqlCommand(sql, conn);
        //        cmd.ExecuteNonQuery();
        //        #endregion
        //        return Ok($"Account {cred.login} successfully created.");
        //    }
        //    catch (MySqlException ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //[HttpPost]
        //public IActionResult CheckName([FromBody] Credentials cred)
        //{
        //    var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        if (UserRepository.LoginExist(cred.login, conn))
        //            return StatusCode(409, "Login is already used.");
        //        else
        //            return Ok($"Login {cred.login} is available.");
        //    }
        //    catch (MySqlException ex)
        //    {
        //        return StatusCode(500, ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
    }
}