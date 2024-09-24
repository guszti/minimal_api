using DemoAPI.database;
using DemoAPI.models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.repository;

public abstract class AbstractBaseRepository<T> : IBaseRepository<T> where T : class, IEntity
{
    protected MyAppContext Db;

    public AbstractBaseRepository(MyAppContext db)
    {
        Db = db;
    }

    public async Task<T> FindOneById(int id)
    {
        return await Db.FindAsync<T>(id);
    }

    public async Task<List<T>> FindAll()
    {
        return await Db.Set<T>().ToListAsync();
    }

    public async Task DeleteOne(int id)
    {
        var entity = await FindOneById(id);

        Db.Set<T>().Remove(entity);
        await Db.SaveChangesAsync();
    }
}