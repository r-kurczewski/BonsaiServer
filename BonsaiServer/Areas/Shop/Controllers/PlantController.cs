using System.Diagnostics;
using BonsaiServer.Database;
using BonsaiServer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace BonsaiServer.Controllers
{
    [Area("Shop")]
    public class PlantShop : ControllerBase
    {
        private readonly AppSettings _appSettings;
        public PlantShop(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        //public IActionResult SellPlant([FromBody] AuthData<int> data)
        //{
        //    var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        int userID = UserRepository.GetUserID(data.cred, conn);
        //        if (!UserRepository.IsUserPlant(data.data, userID, conn)) return StatusCode(403, "Unauthorized.");
        //        var sql = @"SELECT value FROM rarity 
        //                    INNER JOIN plants ON (plants.rarity = rarity.name)
        //                    WHERE plants.id = @id";
        //        var cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@id", data.data);
        //        var rdr = cmd.ExecuteReader();
        //        rdr.Read();
        //        var gold = rdr.GetInt32(0);
        //        rdr.Close();
        //        sql = $"UPDATE currencies SET gold = gold + {gold} where userID = {userID}";
        //        cmd = new MySqlCommand(sql, conn);
        //        cmd.ExecuteNonQuery();
        //        sql = "DELETE FROM plants WHERE plants.id = @id";
        //        cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@id", data.data);
        //        cmd.ExecuteNonQuery();
        //        return Ok(data.data);
        //    }
        //    catch (MySqlException ex)
        //    {
        //        var line = new StackTrace(ex, true).GetFrame(0).ToString();
        //        return StatusCode(500, ex.Message + " " + line);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //public IActionResult GetMoney([FromBody] UserCredentials cred)
        //{
        //    var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        int[] money = new int[2];
        //        int userID = UserRepository.GetUserID(cred, conn);
        //        var sql = $"SELECT gold, gems FROM currencies WHERE userID = {userID}";
        //        var cmd = new MySqlCommand(sql, conn);
        //        var rdr = cmd.ExecuteReader();
        //        rdr.Read();
        //        money[0] = rdr.GetInt32(0);
        //        money[1] = rdr.GetInt32(1);
        //        rdr.Close();
        //        return Ok(money);
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

        //    public IActionResult BuyPlant(int product_id)
        //    {
        //        var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //        try
        //        {
        //            return Ok(product_id);
        //        }
        //        catch (MySqlException ex)
        //        {
        //            return StatusCode(500, ex.Message);
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }

        //    public IActionResult Test()
        //    {
        //        return Ok("Test.");
        //    }
    }
}