using BonsaiServer.Database;

namespace BonsaiServer.Models
{
    public class Rarity
    {
        public enum Tier : byte
        {
            Common,
            Uncommon,
            Rare,
            Very_Rare,
            Unique,
            Premium
        }

        public static Tier FromPlant(Plant plant)
        {
            return plant.Rarity;
        }
    }
}
