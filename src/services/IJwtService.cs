namespace DemoAPI.services;

interface IJwtService
{
    public string GenerateToken(string username);
}