using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    public class Rarity
    {
        public enum Tier
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
            return Tier.Common;
        }
    }
}
