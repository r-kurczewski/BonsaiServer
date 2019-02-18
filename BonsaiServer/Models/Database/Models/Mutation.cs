using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonsaiServer.Database
{
    [Serializable]
    public class Mutation
    {
        public int Id { get; set; }
        public User User { get; set; }
        [ForeignKey("Plant1Id")] public Plant Plant1 { get; set; }
        [ForeignKey("Plant2Id")] public Plant Plant2 { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
