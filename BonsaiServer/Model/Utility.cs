using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace BonsaiServer.Model
{
    public class Utility
    {

        public static T GetObject<T>(MySqlDataReader rdr) where T : class
        {
            var dict = new Dictionary<string, object>();
            for(int i = 0; i<rdr.FieldCount; i++)
                dict[rdr.GetName(i)] = rdr.GetValue(i);
            T result = (T)Activator.CreateInstance(typeof(T));
           return FromDictionary<T>(dict);
        }

        public static T FromDictionary<T>(IDictionary<string, object> dict) where T : class
        {
            Type type = typeof(T);
            T result = (T)Activator.CreateInstance(type);
            foreach (var item in dict)
            {
                var field = type.GetField(item.Key);
                if (field != null) field.SetValue(result, item.Value);
            }
            return result;
        }

        public static Dictionary<string, object> ToDictionary<T>(T obj) where T : class
        {
            var fields = typeof(T).GetFields();

            var result = new Dictionary<string, object>();

            foreach (var field in fields)
            {
                result.Add(field.Name, field.GetValue(obj));
            }
            return result;
        }

        public static List<object> ToList<T>(T obj) where T : class
        {
            var fields = typeof(T).GetFields();

            var result = new List<object>();

            foreach (var field in fields)
            {
                result.Add(field.GetValue(obj));
            }
            return result;
        }

        public static List<string> GetFields<T>() where T : class
        {
            var fields = typeof(T).GetFields();

            var result = new List<string>();

            foreach (var field in fields)
            {
                result.Add(field.Name);
            }
            return result;
        }
    }
}
