using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BonsaiServer.Database
{
    [Serializable]
    public class User
    {
        [Column(Order =0)]public int Id { get; set; }
        [Column(Order = 1)][MaxLength(16)] public string Login { get; set; }
        [Column(Order = 2)][MaxLength(64)] public string PasswordHash { get; set; }
        [Column(Order = 3)][MaxLength(32)] public string Email { get; set; }
    }
}
