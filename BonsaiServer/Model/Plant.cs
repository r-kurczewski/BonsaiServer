using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Model
{
    [Serializable]
    public class Plant
    {
        public int id;
        public string name;
        public int leaves_id;
        public int flower_id;
        public string leaves_color;
        public string flower_color;
        public string stalk_color;
        public string pot_color;
        public string dirt_color;
        public int rarity;
        public int slot;
    }
}
