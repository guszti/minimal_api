using DemoAPI.models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.database;

class MyAppContext : DbContext
{
    public DbSet<Bunny> Bunnies => Set<Bunny>();

    public MyAppContext(DbContextOptions<MyAppContext> options)
        : base(options)
    {
    }
}