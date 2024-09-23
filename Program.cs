using DemoAPI.extensions;
using DemoAPI.services;

var builder = WebApplication.CreateBuilder(args);

builder.AddAppServices();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

RouteGroupingService.MapAllRoutes(app);

app.Run();