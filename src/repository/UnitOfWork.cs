using DemoAPI.database;
using DemoAPI.services;

namespace DemoAPI.repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly MyAppContext _db;

    public IBunnyRepository BunnyRepository { get; }

    public IUserRepository UserRepository { get; }

    public UnitOfWork(MyAppContext db)
    {
        _db = db;

        BunnyRepository = new BunnyRepository(_db);
        UserRepository = new UserRepository(_db);
    }
}