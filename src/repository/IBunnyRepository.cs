using DemoAPI.models;

namespace DemoAPI.repository;

public interface IBunnyRepository : IBaseRepository<Bunny>
{
    public Task<Bunny> CreateOne(Bunny bunny);

    public Task UpdateOne(int id, Bunny bunnyUpdate);
}