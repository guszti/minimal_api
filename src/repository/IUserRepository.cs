using DemoAPI.dto;
using DemoAPI.models;

namespace DemoAPI.repository;

public interface IUserRepository : IBaseRepository<User>
{
    public Task<User> CreateOne(UserDto userDto, string passwordHash);

    public Task<User> FindOneByUsername(string username);
}