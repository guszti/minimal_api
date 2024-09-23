using DemoAPI.dto;
using DemoAPI.services;

namespace DemoAPI.handlers;

public class AuthHandlers
{
    public static IResult SignIn(UserLogInDto user, IJwtService jwtService)
    {
        if (user.Username != "user" || user.Password != "password")
        {
            return Results.Unauthorized();
        }

        var jwt = jwtService.GenerateToken(user.Username);

        return Results.Ok(jwt);
    }

    public static IResult SignOut()
    {
        return Results.Ok();
    }
}