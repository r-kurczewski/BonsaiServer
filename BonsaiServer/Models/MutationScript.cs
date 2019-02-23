using BonsaiServer.Database;
using System;
using System.Linq;

namespace BonsaiServer.Models
{
    public class MutationScript
    {
        private static Random rand = new Random();

        public static Plant Cross(Plant plant1, Plant plant2)
        {
            Plant newPlant = new Plant();
            Random rnd = new Random();
            return newPlant;
        }

        public static string GenerateName()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int length = rand.Next(5, 12);
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rand.Next(s.Length)]).ToArray());
        }
    }
}
