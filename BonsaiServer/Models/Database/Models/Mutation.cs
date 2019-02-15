using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BonsaiServer.Database
{
    public class Mutation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Plant1 { get; set; }
        public int Plant2 { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
