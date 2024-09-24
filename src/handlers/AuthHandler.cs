using DemoAPI.dto;
using DemoAPI.repository;
using DemoAPI.services;

namespace DemoAPI.handlers;

public class AuthHandler
{
    public static async Task<IResult> SignIn(
        UserDto userDto,
        IJwtService jwtService,
        IUnitOfWork unitOfWork,
        IAuthService authService
    )
    {
        var user = await unitOfWork.UserRepository.FindOneByUsername(userDto.Username);

        if (!authService.IsPasswordValid(userDto.PlainPassword, user.Password))
        {
            return Results.Unauthorized();
        }

        var jwt = jwtService.GenerateToken(userDto.Username);

        return Results.Ok(jwt);
    }

    public static async Task<IResult> CreateUser(UserDto userDto, IAuthService authService, IUnitOfWork unitOfWork)
    {
        var passWordHash = authService.HashPaword(userDto.PlainPassword, out var salt);
        var newUser = await unitOfWork.UserRepository.CreateOne(userDto, passWordHash + "." + salt);

        return Results.Created("", new
        {
            id = newUser.Id,
            username = newUser.Username,
            createdAt = newUser.CreatedAt,
            updatedAt = newUser.UpdatedAt
        });
    }
}