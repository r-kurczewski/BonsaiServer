using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Options;
using BonsaiServer.Models;
using BonsaiServer.Database;

namespace BonsaiServer.Controllers
{
    public class MutationController : ControllerBase
    {
        //private readonly AppSettings _appSettings;
        //public MutationController(IOptions<AppSettings> appSettings)
        //{
        //    _appSettings = appSettings.Value;
        //}

        //public IActionResult Get([FromBody] UserCredentials cred)
        //{
        //    MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    var sql = "SELECT id, plant1, plant2, TIMEDIFF(end, NOW()) AS time from mutations INNER JOIN users ON(mutations.userID = users.userID) WHERE login = @login AND password = @password";
        //    try
        //    {
        //        conn.Open();
        //        MySqlCommand cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@login", cred.login);
        //        cmd.Parameters.AddWithValue("@password", cred.password);
        //        MySqlDataReader rdr = cmd.ExecuteReader();
        //        Mutation result = new Mutation();
        //        if (!rdr.HasRows) return StatusCode(204, "No mutation in progress.");
        //        while(rdr.Read())
        //        {
        //            result = UserRepository.GetObject<Mutation>(rdr);
        //        }
        //        rdr.Close();
        //        return Ok(result);
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

        //public IActionResult Set([FromBody] AuthData<Mutation> mutation)
        //{
        //    MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        int userID = UserRepository.GetUserID(mutation.cred, conn);
        //        bool plant1Owned = UserRepository.IsUserPlant(mutation.data.plant1,userID, conn);
        //        bool plant2Owned = UserRepository.IsUserPlant(mutation.data.plant2, userID, conn);
        //        if (!plant1Owned || !plant2Owned || mutation.data.plant1 == mutation.data.plant2) return BadRequest("Wrong plants.");
        //        int time = 10;
        //        var sql = $"INSERT INTO mutations(userID, plant1, plant2, start, end) VALUES ( @userID, @plant1, @plant2, NOW(), NOW() + INTERVAL {time} SECOND)" +
        //            $"ON DUPLICATE KEY UPDATE plant1 = VALUES(plant1), plant2 = VALUES(plant2), start = NOW(), end = NOW() + INTERVAL {time} SECOND";
        //        var cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@userID", userID);
        //        cmd.Parameters.AddWithValue("@plant1", mutation.data.plant1);
        //        cmd.Parameters.AddWithValue("@plant2", mutation.data.plant2);
        //        cmd.ExecuteNonQuery();
        //        return Ok("Success.");
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

        //[HttpGet("collect/{id}")]
        //public IActionResult Collect(int id)
        //{
        //    var cred = new Credentials("radek", "450a10fad8bc1453cf4690e7391f34df4e7c3621ccc7e1b45699190c6acc36e4");
        //    var data = new AuthData<int>(cred, id);
        //    return Collect(data);
        //}

        //[HttpPost]
        //public IActionResult Collect([FromBody] AuthData<int> data)
        //{
        //    var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        var plants = new List<Plant>();
        //        int userID = UserRepository.GetUserID(data.cred, conn);
        //        var sql = $@"SELECT plants.* FROM plants 
        //                    INNER JOIN mutations ON (plants.id = mutations.plant1 OR plants.id = mutations.plant2)
        //                    INNER JOIN users ON (users.userID = plants.userID)
        //                    WHERE plants.userID = {userID} AND mutations.id = @id";
        //        var cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@id", data.data);
        //        var rdr = cmd.ExecuteReader();
        //        while (rdr.Read())
        //        {
        //            plants.Add(UserRepository.GetObject<Plant>(rdr));
        //        }
        //        rdr.Close();
        //        var newPlant = MutationScript.Cross(plants);
        //        var plantDict = Utility.ToDictionary(newPlant);
        //        var plantFields = $"`{String.Join("`, `", plantDict.Keys)}`";
        //        var plantValues = $"'{String.Join("', '", plantDict.Values)}'";
        //        sql = $@"INSERT INTO plants(userID, {plantFields}) VALUES ({userID}, {plantValues})";
        //        cmd = new MySqlCommand(sql, conn);
        //        cmd.ExecuteNonQuery();
        //        sql = $"DELETE FROM mutations WHERE id = {data.data}";
        //        cmd = new MySqlCommand(sql, conn);
        //        cmd.ExecuteNonQuery();
        //        return Ok("Plant created.");
        //    }
        //    catch(MySqlException ex)
        //    {
        //        switch (ex.ErrorCode)
        //        {
        //            default:
        //                return StatusCode(500, ex.Message);
        //        }
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        //public IActionResult Abort([FromBody] AuthData<int> data)
        //{
        //    var conn = new MySqlConnection(_appSettings.DefaultConnection);
        //    try
        //    {
        //        conn.Open();
        //        int userID = UserRepository.GetUserID(data.cred, conn);
        //        var sql = $"DELETE FROM mutations WHERE userID = {userID} AND id = @id";
        //        var cmd = new MySqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@id", data.data);
        //        cmd.ExecuteNonQuery();
        //        return Ok();
        //    }
        //    catch(MySqlException ex)
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