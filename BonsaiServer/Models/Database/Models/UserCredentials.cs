using System;
using System.ComponentModel.DataAnnotations;

namespace BonsaiServer.Database
{
    [Serializable]
    public class UserCredentials
    {
        public int Id { get; set; }
        [MaxLength(16)] public string Login { get; set; }
        [MaxLength(64)] public string PasswordHash { get; set; }
        [MaxLength(32)] public string Email { get; set; }
    }
}
