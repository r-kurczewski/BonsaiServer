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
        public int leaves_id;
        public int leaves_color;
        public int flower_id;
        public int flower_color;
        public int stalk_color;
        public int pot_color;
        public int dirt_color;
        public int slot;
    }
}
