using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI.models;

[Table("user")]
public class User : AbstractEntity, IUser
{
    [Column("username")] public string Username { get; set; }

    [Column("password")] public string Password { get; set; }
}