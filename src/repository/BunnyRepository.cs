using DemoAPI.database;
using DemoAPI.models;

namespace DemoAPI.repository;

public class BunnyRepository : AbstractBaseRepository<Bunny>, IBunnyRepository
{
    public BunnyRepository(MyAppContext db) : base(db)
    {
    }

    public async Task<Bunny> CreateOne(Bunny bunny)
    {
        var newBunny = new Bunny()
        {
            Age = bunny.Age,
            Sex = bunny.Sex,
            Breed = bunny.Breed
        };

        var createdBunny = Db.Bunny.Add(newBunny).Entity;
        await Db.SaveChangesAsync();

        return createdBunny;
    }

    public async Task UpdateOne(int id, Bunny bunnyUpdate)
    {
        var bunny = await Db.Bunny.FindAsync(id);

        bunny.Age = bunnyUpdate.Age;
        bunny.Breed = bunnyUpdate.Breed;
        bunny.Sex = bunnyUpdate.Sex;

        await Db.SaveChangesAsync();
    }
}