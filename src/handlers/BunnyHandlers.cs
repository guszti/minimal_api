using DemoAPI.database;
using DemoAPI.models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.handlers;

static class BunnyHandlers
{
    public static async Task<List<Bunny>> GetMany(MyAppContext db)
    {
        return await db.Bunnies.ToListAsync();
    }

    public static Task<string> CreateOne()
    {
        return Task.FromResult("Asd");
    }
}