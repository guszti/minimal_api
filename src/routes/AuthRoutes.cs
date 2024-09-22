using DemoAPI.handlers;

namespace DemoAPI.routes;

class AuthRoutes : IAppRoutes
{
    public static void MapRoutes(WebApplication app)
    {
        var group = app.MapGroup("auth");

        group.MapPost("/sign-in", AuthHandlers.SignIn);
        group.MapPost("/sign-out", AuthHandlers.SignOut);
    }
}