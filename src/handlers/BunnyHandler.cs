using DemoAPI.database;
using DemoAPI.models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.handlers;

public static class BunnyHandler
{
    public static async Task<IResult> GetMany(MyAppContext db)
    {
        return Results.Ok(await db.Bunny.ToListAsync());
    }

    public static async Task<IResult> GetOne(int id, MyAppContext db)
    {
        var bunny = await db.Bunny.FindAsync(id);

        if (bunny is null)
        {
            return Results.NotFound();
        }

        return Results.Ok(bunny);
    }

    public static async Task<IResult> CreateOne(Bunny bunny, MyAppContext db)
    {
        var newBunny = new Bunny()
        {
            Age = bunny.Age,
            Sex = bunny.Sex,
            Breed = bunny.Breed
        };

        var createdBunny = db.Bunny.Add(newBunny).Entity;
        await db.SaveChangesAsync();

        return Results.Created("", createdBunny);
    }

    public static async Task<IResult> UpdateOne(int id, Bunny bunnyUpdate, MyAppContext db)
    {
        var bunny = await db.Bunny.FindAsync(id);

        if (bunny is null)
        {
            return Results.NotFound();
        }

        bunny.Age = bunnyUpdate.Age;
        bunny.Breed = bunnyUpdate.Breed;
        bunny.Sex = bunnyUpdate.Sex;

        await db.SaveChangesAsync();

        return Results.NoContent();
    }

    public static async Task<IResult> DeleteOne(int id, MyAppContext db)
    {
        var bunny = await db.Bunny.FindAsync(id);

        if (bunny is null)
        {
            return Results.NotFound();
        }

        db.Bunny.Remove(bunny);
        await db.SaveChangesAsync();

        return Results.NoContent();
    }
}