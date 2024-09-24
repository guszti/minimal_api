using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPI.models;

public abstract class AbstractEntity : IEntity
{
    [Column("id")] public int Id { get; set; }

    [Column("created_at")] public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("updated_at")] public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}