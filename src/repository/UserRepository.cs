using DemoAPI.database;
using DemoAPI.dto;
using DemoAPI.models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.repository;

public class UserRepository : AbstractBaseRepository<User>, IUserRepository
{
    public UserRepository(MyAppContext db) : base(db)
    {
    }

    public async Task<User> CreateOne(UserDto userDto, string passwordHash)
    {
        var user = new User()
        {
            Username = userDto.Username,
            Password = passwordHash
        };

        var createdUser = Db.User.Add(user).Entity;
        await Db.SaveChangesAsync();

        return createdUser;
    }

    public async Task<User> FindOneByUsername(string username)
    {
        return await Db.User.FirstOrDefaultAsync(i => i.Username == username);
    }
}