using System.ComponentModel.DataAnnotations;

namespace BonsaiServer.Model
{
    public class User
    {
        public int Id { get; set; }
        [MaxLength(20)] public string Login { get; set; }
        [MaxLength(64)] public string PasswordHash { get; set; }
        [MaxLength(30)] public string Email { get; set; }
    }
}
