using GamerShopAPI;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

builder.WebHost.UseUrls("http://*:5001");

startup.Configure(app, app.Environment);

app.Run();
