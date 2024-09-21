using DemoAPI.enums;

namespace DemoAPI.models;

class Bunny : Entity, IBunny
{
    public Sex Sex { get; set; }

    public Breed Breed { get; set; }

    public int Age { get; set; }
}