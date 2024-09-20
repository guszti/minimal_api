using DemoAPI.services.Routing;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

RouteGroupingService.MapAllRoutes(app);

app.Run();
