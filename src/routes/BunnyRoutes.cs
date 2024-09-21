using DemoAPI.handlers;

namespace DemoAPI.routes;

static class BunnyRoutes
{
    public static void MapBunnyRoutes(WebApplication app)
    {
        var group = app.MapGroup("bunnies");

        group.MapGet("/", BunnyHandlers.GetMany);
    }
}