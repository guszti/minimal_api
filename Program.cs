using DemoAPI.database;
using DemoAPI.services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MyAppContext>(opt =>
    opt.UseNpgsql(builder.Configuration.GetConnectionString("postgres")));
builder.Services.AddScoped<MyAppContext>();

var app = builder.Build();

RouteGroupingService.MapAllRoutes(app);

app.Run();