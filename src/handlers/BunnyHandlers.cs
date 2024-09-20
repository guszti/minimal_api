namespace DemoAPI.handlers;

static class BunnyHandlers
{
    public static Task<List<string>> GetMany()
    {
        return Task.FromResult<List<string>>(["bunny1", "bunny2"]);
    }

    public static Task<string> CreateOne()
    {
        return Task.FromResult("Asd");
    }
}