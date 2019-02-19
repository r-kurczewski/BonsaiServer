using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonsaiServer.Database
{
    [Serializable]
    public class User
    {
        public int Id { get; set; }
        [MaxLength(16)] public string Login { get; set; }
        [MaxLength(64)] public string PasswordHash { get; set; }
        [MaxLength(64)] public string Session { get; set; }
        [MaxLength(32)] public string Email { get; set; }
        public virtual ICollection<Plant> Plants { get; set; }
    }
}
