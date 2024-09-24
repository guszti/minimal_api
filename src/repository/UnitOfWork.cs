using DemoAPI.database;

namespace DemoAPI.repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly MyAppContext _db;

    public IBunnyRepository BunnyRepository { get; }

    public UnitOfWork(MyAppContext db)
    {
        _db = db;

        BunnyRepository = new BunnyRepository(_db);
    }
}