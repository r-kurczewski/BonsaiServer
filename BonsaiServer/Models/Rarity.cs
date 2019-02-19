using BonsaiServer.Database;
using System.ComponentModel.DataAnnotations;

namespace BonsaiServer.Models
{
    public class Rarity
    {
        public enum Tier : byte
        {
            Common,
            Uncommon,
            Rare,
            [Display(Name = "Very Rare")] Very_Rare,
            Unique,
            Premium
        }

        public static Tier FromPlant(Plant plant)
        {
            return plant.Rarity;
        }
    }
}
