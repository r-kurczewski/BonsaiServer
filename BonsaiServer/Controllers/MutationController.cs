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
            var sql = "SELECT plant1, plant2, end-NOW() AS time from mutations INNER JOIN users ON(mutations.userID = users.userID) WHERE login = @login AND password = @password";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@login", cred.login);
                cmd.Parameters.AddWithValue("@password", cred.password);
                MySqlDataReader rdr = cmd.ExecuteReader();
                MutationData result = new MutationData(0, 0, -1);
                if (rdr.HasRows)
                {
                    rdr.Read();
                    result = Utility.GetObject<MutationData>(rdr);
                    rdr.Close();
                }
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        [HttpPost("set")]
        public IActionResult SetMutation([FromBody] AuthorizedData<MutationData> mutation)
        {
            MySqlConnection conn = new MySqlConnection(_appSettings.DefaultConnection);
            try
            {
                conn.Open();
                int userID = SQLHelper.GetUserID(mutation.cred, conn);
                int time = 3600;
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
                return BadRequest(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        [Serializable]
        public class MutationData
        {
            public int plant1;
            public int plant2;
            public long time;

            public MutationData()
            {
            }

            public MutationData(int plant1, int plant2, int time)
            {
                this.plant1 = plant1;
                this.plant2 = plant2;
                this.time = time;
            }
        }
    }
}