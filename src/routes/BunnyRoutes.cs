using DemoAPI.handlers;

namespace DemoAPI.routes;

static class BunnyRoutes
{
    public static void MapBunnyRoutes(WebApplication app)
    {
        var group = app.MapGroup("bunnies");

        group.MapGet("/", BunnyHandlers.GetMany);
        group.MapGet("/{id}", BunnyHandlers.GetOne);
        group.MapPost("/", BunnyHandlers.CreateOne);
        group.MapPut("/{id}", BunnyHandlers.UpdateOne);
        group.MapDelete("/{id}", BunnyHandlers.DeleteOne);
    }
}