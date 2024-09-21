using DemoAPI.routes;

namespace DemoAPI.services;

static class RouteGroupingService
{
    public static void MapAllRoutes(WebApplication app)
    {
        BunnyRoutes.MapBunnyRoutes(app);
    }
}