using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using BonsaiServer.Model;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    [Route("db")]
    public class DatabaseController : ControllerBase
    {
        private readonly AppSettings _appSettings;
        public DatabaseController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        public IActionResult TableNames()
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                var result = new List<string>{"Available tables:"};
                var sql = "show tables";
                var cmd = new MySqlCommand(sql, conn);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    result.Add(rdr.GetString(0));
                }
                rdr.Close();
                return Content(string.Join("\n", result));
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        [HttpGet("{table}")]
        public IActionResult Get(string table)
        {
            var result = new List<Dictionary<string, object>>();
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();

                var sql = "SELECT * FROM " + table + " LIMIT 15";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Dictionary<string, object> temp = new Dictionary<string, object>();
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        temp.Add(rdr.GetName(i), rdr.GetValue(i));
                    }
                    result.Add(temp);
                }
                rdr.Close();
                return Ok(result);
            }
            catch (Exception ex)
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