namespace DemoAPI.services;

public interface IAuthService
{
    public string HashPaword(string plainPassword, out string salt);

    public bool IsPasswordValid(string plainPassword, string passwordHash);
}