using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonsaiServer.Database
{
    [Serializable]
    public class Mutation
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        public int Plant1Id { get; set; }
        public int Plant2Id { get; set; }

        [ForeignKey("Plant1Id")]
        public Plant Plant1 { get; set; }

        [ForeignKey("Plant2Id")]
        public Plant Plant2 { get; set; }

        public DateTime End { get; set; }
    }
}
