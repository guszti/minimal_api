using DemoAPI.handlers;

namespace DemoAPI.routes;

public class BunnyRoutes : IAppRoute
{
    public static void MapRoutes(WebApplication app)
    {
        var group = app.MapGroup("bunnies").RequireAuthorization();

        group.MapGet("/", BunnyHandler.GetMany);
        group.MapGet("/{id}", BunnyHandler.GetOne);
        group.MapPost("/", BunnyHandler.CreateOne);
        group.MapPut("/{id}", BunnyHandler.UpdateOne);
        group.MapDelete("/{id}", BunnyHandler.DeleteOne);
    }
}