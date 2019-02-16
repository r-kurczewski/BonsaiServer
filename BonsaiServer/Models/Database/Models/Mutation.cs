using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonsaiServer.Database
{
    [Serializable]
    public class Mutation
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Plant Plant1 { get; set; }
        public Plant Plant2 { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
