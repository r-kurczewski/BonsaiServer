using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BonsaiServer.Model
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
