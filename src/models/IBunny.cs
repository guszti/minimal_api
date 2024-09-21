using DemoAPI.enums;

namespace DemoAPI.models;

interface IBunny : IEntity
{
    public Sex Sex { get; set; }

    public Breed Breed { get; set; }

    public int Age { get; set; }
}