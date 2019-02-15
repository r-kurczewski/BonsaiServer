using BonsaiServer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BonsaiServer.Models
{
    public class MutationScript
    {
        private static Random rand = new Random();
        public static List<string> mutableFields = new List<string>()
        { "leaves_id", "leaves_color", "flower_id", "flower_color", "stalk_color", "dirt_color" };

        public static Plant Cross(List<Plant> plants)
        {
            Plant newPlant = new Plant();
            Random rnd = new Random();
            foreach (var fieldName in mutableFields)
            {
                FieldInfo field = newPlant.GetType().GetField(fieldName);
                field.SetValue(newPlant, field.GetValue(plants[rnd.Next(0,2)]));
            }
            newPlant.Slot = 0;
            newPlant.Name = GenerateName(newPlant);
            newPlant.PotColor = "f95";
            newPlant.Rarity = GetRarity(newPlant);
            return newPlant;
        }

        static string GenerateName(Plant plant)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int length = rand.Next(5, 12);
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }

        public static List<string> GetMutableStringValues(Plant plant)
        {
            var result = new List<string>();
            foreach(var field in mutableFields)
            {
                result.Add(typeof(Plant).GetField(field).GetValue(plant).ToString());
            }
            return result;
        }

        private static Rarity.Tier GetRarity(Plant plant)
        {
            return Rarity.Tier.Premium;
        }
    }
}
