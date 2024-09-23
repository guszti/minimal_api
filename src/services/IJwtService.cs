namespace DemoAPI.services;

public interface IJwtService
{
    public string GenerateToken(string username);
}