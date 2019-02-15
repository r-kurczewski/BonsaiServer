using System;
using System.Collections.Generic;

namespace BonsaiServer.Models
{
    public class Utility
    {
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

        public static Dictionary<string, object> ToDictionary<T>(T obj, bool skipNull = true) where T : class
        {
            var fields = typeof(T).GetFields();

            var result = new Dictionary<string, object>();

            foreach (var field in fields)
            {
                var value = field.GetValue(obj);
                if (value == null && skipNull) continue;
                result.Add(field.Name, value);
            }
            return result;
        }

        public static List<object> GetValues<T>(T obj) where T : class
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

        public static List<string> GetFields<T>(T obj) where T : class
        {
            return GetFields<T>();
        }
    }
}
