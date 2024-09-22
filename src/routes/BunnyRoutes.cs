using DemoAPI.handlers;

namespace DemoAPI.routes;

class BunnyRoutes : IAppRoutes
{
    public static void MapRoutes(WebApplication app)
    {
        var group = app.MapGroup("bunnies");

        group.MapGet("/", BunnyHandlers.GetMany);
        group.MapGet("/{id}", BunnyHandlers.GetOne);
        group.MapPost("/", BunnyHandlers.CreateOne);
        group.MapPut("/{id}", BunnyHandlers.UpdateOne);
        group.MapDelete("/{id}", BunnyHandlers.DeleteOne);
    }
}