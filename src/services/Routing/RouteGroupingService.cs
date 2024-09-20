using DemoAPI.routes;

namespace DemoAPI.services.Routing;

static class RouteGroupingService
{
    public static RouteGroupBuilder MapRoutes(this RouteGroupBuilder group, List<RouteData> routes)
    {
        foreach (var item in routes)
        {
            switch (item.Method)
            {
                case HttpMethod.GET:
                    group.MapGet(item.Path, item.CallBack);

                    break;
                default:
                    throw new Exception("Invalid http method");
            }
        }

        return group;
    }

    public static void MapAllRoutes(WebApplication app)
    {
        BunnyRoutes.MapBunnyRoutes(app);
    }
}