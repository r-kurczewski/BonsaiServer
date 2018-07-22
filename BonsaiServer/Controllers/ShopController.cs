﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BonsaiServer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;

namespace BonsaiServer.Controllers
{
    [Route("{controller}")]
    public class ShopController : Controller
    {
        private readonly AppSettings _appSettings;
        public ShopController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [Route("sell")]
        [HttpPost]
        public IActionResult SellPlant([FromBody] AuthData<int> data)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                int userID = SQLHelper.GetUserID(data.cred, conn);
                if (!SQLHelper.IsUserPlant(data.data, userID, conn)) return StatusCode(403, "Unauthorized.");
                var sql = @"SELECT value FROM rarity 
                            INNER JOIN plants ON (plants.rarity = rarity.name)
                            WHERE id = @id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", data.data);
                var rdr = cmd.ExecuteReader();
                rdr.Read();
                var gold = rdr.GetInt32(0);
                rdr.Close();
                sql = $"UPDATE currencies SET gold = gold + {gold} where userID = {userID}";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                sql = "DELETE FROM plants WHERE plants.id = @id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", data.data);
                cmd.ExecuteNonQuery();
                return Ok(data.data);
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

        [Route("getMoney")]
        [HttpPost]
        public IActionResult GetMoney(Credentials cred)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                int[] money = new int[2];
                int userID = SQLHelper.GetUserID(cred, conn);
                var sql = $"SELECT gold, gems FROM currencies WHERE userID = {userID}";
                var cmd = new MySqlCommand(sql, conn);
                var rdr = cmd.ExecuteReader();
                rdr.Read();
                money[0] = rdr.GetInt32(0);
                money[1] = rdr.GetInt32(1);
                return Ok(money);
            }
            catch(MySqlException ex)
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