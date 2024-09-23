using DemoAPI.routes;

namespace DemoAPI.services;

public static class RouteGroupingService
{
    public static void MapAllRoutes(WebApplication app)
    {
        AuthRoutes.MapRoutes(app);
        BunnyRoutes.MapRoutes(app);
    }
}