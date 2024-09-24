using DemoAPI.models;

namespace DemoAPI.repository;

public interface IBaseRepository<T> where T : class, IEntity
{
    public Task<T> FindOneById(int id);

    public Task<List<T>> FindAll();

    public Task DeleteOne(int id);
}