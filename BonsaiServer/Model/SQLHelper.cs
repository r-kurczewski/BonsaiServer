using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    public class SQLHelper
    {
        public static int GetUserID(Credentials cred, MySqlConnection conn)
        {
            int result = 0;
            var sql = "SELECT userID FROM users WHERE login = @login AND password = @password;";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@login", cred.login);
            cmd.Parameters.AddWithValue("@password", cred.password);
            var rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                rdr.Read();
                result = rdr.GetInt32(0);
                rdr.Close();
            }
            return result;
        } 
    }
}
