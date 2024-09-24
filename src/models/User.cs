using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.models;

[Table("user")]
[Index(nameof(Username), IsUnique = true)]
public class User : AbstractEntity, IUser
{
    [Column("username")] public string Username { get; set; }

    [Column("password")] public string Password { get; set; }
}