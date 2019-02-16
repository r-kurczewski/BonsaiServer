using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using BonsaiServer.Models;
using Microsoft.Extensions.Options;
using BonsaiServer.Database;
using System.Linq;

namespace BonsaiServer.Controllers
{
    public class PlantsController : ControllerBase
    {
        private readonly IPlantRepository plantRepository;
        public PlantsController(IPlantRepository repository)
        {
            this.plantRepository = repository;
        }
        [HttpPost]
        public IActionResult Get([FromBody] Session session)
        {
            List<Plant> plants = plantRepository.GetPlantsOfUser(session).ToList();
            if(plants.Count == 0)
            {

            }
            else if(plants.Count > 0)
            {

            }
            else
            {

            }
            return Ok();
        }

        //[HttpPost]
        //public IActionResult Move([FromBody] AuthData<List<int[]>> updates)
        //{
        //    MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        int userID = UserRepository.GetUserID(updates.cred, conn);
        //        foreach (var arr in updates.data)
        //        {
        //            var sql = $"UPDATE plants SET slot = @slot WHERE id = @id AND userID = {userID}";
        //            var cmd = new MySqlCommand(sql, conn);
        //            cmd.Parameters.AddWithValue("@id", arr[0]);
        //            cmd.Parameters.AddWithValue("@slot", arr[1]);
        //            cmd.ExecuteNonQuery();
        //        }
        //        return Ok("Successful.");
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, ex.ToString());
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //[HttpPost]
        //public IActionResult Rename([FromBody] AuthData<Dictionary<int, string>> data)
        //{
        //    var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        int userID = UserRepository.GetUserID(data.cred, conn);
        //        foreach (var item in data.data)
        //        {
        //            var sql = $"UPDATE plants SET name = @name WHERE userID = {userID} AND id = @id";
        //            var cmd = new MySqlCommand(sql, conn);
        //            cmd.Parameters.AddWithValue("@name", item.Value);
        //            cmd.Parameters.AddWithValue("@id", item.Key);
        //            cmd.ExecuteNonQuery();
        //        }
        //        return Ok();
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