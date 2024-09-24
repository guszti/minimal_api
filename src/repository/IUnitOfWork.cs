namespace DemoAPI.repository;

public interface IUnitOfWork
{
    public IBunnyRepository BunnyRepository { get; }
}