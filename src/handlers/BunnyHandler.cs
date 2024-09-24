using DemoAPI.models;
using DemoAPI.repository;

namespace DemoAPI.handlers;

public static class BunnyHandler
{
    public static async Task<IResult> GetMany(IUnitOfWork unitOfWork)
    {
        var result = await unitOfWork.BunnyRepository.FindAll();

        return Results.Ok(result);
    }

    public static async Task<IResult> GetOne(int id, IUnitOfWork unitOfWork)
    {
        var bunny = await unitOfWork.BunnyRepository.FindOneById(id);

        return Results.Ok(bunny);
    }

    public static async Task<IResult> CreateOne(Bunny bunny, IUnitOfWork unitOfWork)
    {
        var newBunny = await unitOfWork.BunnyRepository.CreateOne(bunny);

        return Results.Created("", newBunny);
    }

    public static async Task<IResult> UpdateOne(int id, Bunny bunnyUpdate, IUnitOfWork unitOfWork)
    {
        await unitOfWork.BunnyRepository.UpdateOne(id, bunnyUpdate);

        return Results.NoContent();
    }

    public static async Task<IResult> DeleteOne(int id, IUnitOfWork unitOfWork)
    {
        await unitOfWork.BunnyRepository.DeleteOne(id);

        return Results.NoContent();
    }
}