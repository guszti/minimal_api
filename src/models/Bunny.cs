using DemoAPI.enums;

namespace DemoAPI.models;

public class Bunny : Entity, IBunny
{
    public Sex Sex { get; set; }

    public Breed Breed { get; set; }

    public int Age { get; set; }
}