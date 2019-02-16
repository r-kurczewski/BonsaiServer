using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonsaiServer.Database
{
    [Serializable]
    public class Session
    {
        public int Id { get; set; }
        public virtual User User { get; set; }
        [MaxLength(64)] public string SessionHash { get; set; }
    }
}
