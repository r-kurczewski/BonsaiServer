using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    public class SQLHelper
    {
        public static T GetObject<T>(MySqlDataReader rdr) where T : class
        {
            var dict = new Dictionary<string, object>();
            for (int i = 0; i < rdr.FieldCount; i++)
                dict[rdr.GetName(i)] = rdr.GetValue(i);
            T result = (T)Activator.CreateInstance(typeof(T));
            return Utility.FromDictionary<T>(dict);
        }

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
            }
            rdr.Close();
            return result;
        }

        public static bool IsUserPlant(int plantID, int userID, MySqlConnection conn)
        {
            var sql = $"SELECT id FROM plants WHERE userID = @userID AND id = @plantID";
            var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@userID", userID);
            cmd.Parameters.AddWithValue("@plantID", plantID);
            var rdr = cmd.ExecuteReader();
            var result = rdr.HasRows;
            rdr.Close();
            return result;
        }

        public static bool LoginExist(string login, MySqlConnection conn)
        {
            var result = false;
            var sql = $"SELECT COUNT(*) FROM users WHERE login = '{login}'";
            var cmd = new MySqlCommand(sql, conn);
            var rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0) result = true;
            rdr.Close();
            return result;
        }

        public static bool EmailExist(string email, MySqlConnection conn)
        {
            var result = false;
            var sql = $"SELECT COUNT(*) FROM users WHERE email = '{email}'";
            var cmd = new MySqlCommand(sql, conn);
            var rdr = cmd.ExecuteReader();
            rdr.Read();
            if (rdr.GetInt32(0) > 0) result = true;
            rdr.Close();
            return result;
        }
    }
}
