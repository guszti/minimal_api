namespace DemoAPI.repository;

public interface IUnitOfWork
{
    public IBunnyRepository BunnyRepository { get; }

    public IUserRepository UserRepository { get; }
}