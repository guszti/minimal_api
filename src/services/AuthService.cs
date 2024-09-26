using System.Security.Cryptography;
using System.Text;

namespace DemoAPI.services;

public class AuthService : IAuthService
{
    private const int KeySize = 64;
    private const int Iterations = 350000;
    private readonly HashAlgorithmName _hashAlgorithm = HashAlgorithmName.SHA512;

    public string HashPaword(string plainPassword, out string saltString)
    {
        var salt = RandomNumberGenerator.GetBytes(KeySize);

        var hash = Rfc2898DeriveBytes.Pbkdf2(
            Encoding.UTF8.GetBytes(plainPassword),
            salt,
            Iterations,
            _hashAlgorithm,
            KeySize
        );

        saltString = Convert.ToHexString(salt);

        return Convert.ToHexString(hash);
    }

    public bool IsPasswordValid(string plainPassword, string passwordHash)
    {
        var passwordAndHash = passwordHash.Split('.');
        var hashToCompare =
            Rfc2898DeriveBytes.Pbkdf2(
                plainPassword,
                Convert.FromHexString(passwordAndHash[1]),
                Iterations,
                _hashAlgorithm,
                KeySize
            );

        return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(passwordAndHash[0]));
    }
}