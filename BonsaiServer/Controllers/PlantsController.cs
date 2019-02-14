using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using BonsaiServer.Model;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    public class PlantsController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        public PlantsController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Get(DebugController.cred);
        }

        [HttpPost]
        public IActionResult Get([FromBody]Credentials cred)
        {
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            var result = new List<Plant>();
            try
            {
                conn.Open();
                var fields = Utility.GetFields<Plant>();
                var select = String.Join(", ", fields);
                var sql = $@"SELECT {select} FROM plants 
                             INNER JOIN users ON (users.userID = plants.userID) 
                             WHERE login = @login AND password = @password ORDER BY id ASC";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", cred.login);
                cmd.Parameters.AddWithValue("@password", cred.password);
                var rdr = cmd.ExecuteReader();
                //if (!rdr.HasRows) return NoContent();
                while (rdr.Read())
                    result.Add(SQLHelper.GetObject<Plant>(rdr));
                rdr.Close();
                return Ok(result);
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

        [HttpPost]
        public IActionResult Move([FromBody] AuthData<List<int[]>> updates)
        {
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                int userID = SQLHelper.GetUserID(updates.cred, conn);
                foreach (var arr in updates.data)
                {
                    var sql = $"UPDATE plants SET slot = @slot WHERE id = @id AND userID = {userID}";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", arr[0]);
                    cmd.Parameters.AddWithValue("@slot", arr[1]);
                    cmd.ExecuteNonQuery();
                }
                return Ok("Successful.");
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

        [HttpPost]
        public IActionResult Rename([FromBody] AuthData<Dictionary<int, string>> data)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                int userID = SQLHelper.GetUserID(data.cred, conn);
                foreach (var item in data.data)
                {
                    var sql = $"UPDATE plants SET name = @name WHERE userID = {userID} AND id = @id";
                    var cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@name", item.Value);
                    cmd.Parameters.AddWithValue("@id", item.Key);
                    cmd.ExecuteNonQuery();
                }
                return Ok();
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
    }
}