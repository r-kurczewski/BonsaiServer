using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Configuration;
using BonsaiServer.Model;
using Microsoft.Extensions.Options;

namespace BonsaiServer.Controllers
{
    [Route("[controller]")]
    public class MutationController : Controller
    {
        private readonly AppSettings _appSettings;
        public MutationController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        
        [HttpPost("get")]
        public IActionResult GetMutation([FromBody] Credentials cred)
        {
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            var sql = "SELECT id, plant1, plant2, TIMEDIFF(end, NOW()) AS time from mutations INNER JOIN users ON(mutations.userID = users.userID) WHERE login = @login AND password = @password";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", cred.login);
                cmd.Parameters.AddWithValue("@password", cred.password);
                MySqlDataReader rdr = cmd.ExecuteReader();
                Mutation result = new Mutation();
                if (!rdr.HasRows) return StatusCode(204, "No mutation in progress.");
                while(rdr.Read())
                {
                    result = SQLHelper.GetObject<Mutation>(rdr);
                }
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

        [HttpPost("set")]
        public IActionResult SetMutation([FromBody] AuthData<Mutation> mutation)
        {
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                int userID = SQLHelper.GetUserID(mutation.cred, conn);
                bool plant1Owned = SQLHelper.IsUserPlant(mutation.data.plant1,userID, conn);
                bool plant2Owned = SQLHelper.IsUserPlant(mutation.data.plant2, userID, conn);
                if (!plant1Owned || !plant2Owned || mutation.data.plant1 == mutation.data.plant2) return BadRequest("Wrong plants.");
                int time = 10;
                var sql = $"INSERT INTO mutations(userID, plant1, plant2, start, end) VALUES ( @userID, @plant1, @plant2, NOW(), NOW() + INTERVAL {time} SECOND)" +
                    $"ON DUPLICATE KEY UPDATE plant1 = VALUES(plant1), plant2 = VALUES(plant2), start = NOW(), end = NOW() + INTERVAL {time} SECOND";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@plant1", mutation.data.plant1);
                cmd.Parameters.AddWithValue("@plant2", mutation.data.plant2);
                cmd.ExecuteNonQuery();
                return Ok("Success.");
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

        [HttpPost("collect")]
        public IActionResult Collect([FromBody] AuthData<Mutation> data)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                var plants = new List<Plant>();
                int userID = SQLHelper.GetUserID(data.cred, conn);
                var sql = $@"SELECT plants.* FROM plants 
                            INNER JOIN mutations ON (plants.id = mutations.plant1 OR plants.id = mutations.plant2)
                            INNER JOIN users ON (users.userID = plants.userID)
                            WhERE plants.userID = {userID} AND mutations.id = @id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", data.cred.login);
                cmd.Parameters.AddWithValue("@password", data.cred.password);
                cmd.Parameters.AddWithValue("@id", data.data.id);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    plants.Add(SQLHelper.GetObject<Plant>(rdr));
                }
                rdr.Close();
                var newPlant = MutationScript.Cross(plants);
                var plantFields = String.Join(", ", Utility.GetFields(newPlant).Skip(1)); //skip id
                var plantValues = Utility.ToStringList(newPlant).Skip(1); //skip id
                var plantValuesString = $"'{String.Join("', '", plantValues)}'";
                sql = $@"INSERT INTO plants VALUES (null, {userID}, {plantValuesString})";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                sql = $"DELETE FROM mutations WHERE id = {data.data.id}";
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                return Ok("Plant created.");
            }
            catch(MySqlException ex)
            {
                switch (ex.ErrorCode)
                {
                    default:
                        return StatusCode(500, ex.Message);
                }
            }
            finally
            {
                conn.Close();
            }
        }

        [HttpPost("abort")]
        public IActionResult Abort([FromBody] AuthData<int> data)
        {
            var conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                int userID = SQLHelper.GetUserID(data.cred, conn);
                var sql = $"DELETE FROM mutations WHERE userID = {userID} AND id = @id";
                var cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", data.data);
                cmd.ExecuteNonQuery();
                return Ok();
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

        [Serializable]
        public class Mutation
        {
            public int id;
            public int plant1;
            public int plant2;
            public TimeSpan time;

            public Mutation()
            {

            }
        }
    }
}