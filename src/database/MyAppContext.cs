using DemoAPI.models;
using Microsoft.EntityFrameworkCore;

namespace DemoAPI.database;

public class MyAppContext : DbContext
{
    public DbSet<Bunny> Bunny => Set<Bunny>();

    public DbSet<User> User => Set<User>();

    public MyAppContext(DbContextOptions<MyAppContext> options)
        : base(options)
    {
    }
}