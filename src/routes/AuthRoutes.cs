using DemoAPI.handlers;

namespace DemoAPI.routes;

public class AuthRoutes : IAppRoute
{
    public static void MapRoutes(WebApplication app)
    {
        var group = app.MapGroup("auth");

        group.MapPost("/sign-in", AuthHandler.SignIn);
        group.MapPost("/sign-out", AuthHandler.SignOut);
    }
}