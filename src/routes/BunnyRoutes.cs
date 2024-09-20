using DemoAPI.handlers;
using DemoAPI.services.Routing;
using HttpMethod = DemoAPI.services.Routing.HttpMethod;
using RouteData = DemoAPI.services.Routing.RouteData;

namespace DemoAPI.routes;

static class BunnyRoutes
{
    public static void MapBunnyRoutes(WebApplication app)
    {
        var routes = new List<RouteData>([
            new RouteData("/", HttpMethod.GET, BunnyHandlers.GetMany)
        ]);

        app.MapGroup("bunny").MapRoutes(routes);
    }
}