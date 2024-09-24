using System.ComponentModel.DataAnnotations.Schema;
using DemoAPI.enums;

namespace DemoAPI.models;

[Table("bunny")]
public class Bunny : AbstractEntity, IBunny
{
    [Column("sex")] public Sex Sex { get; set; }

    [Column("breed")] public Breed Breed { get; set; }

    [Column("age")] public int Age { get; set; }
}