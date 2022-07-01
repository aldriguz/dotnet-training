using ServiceLifetime.Interfaces;
using ServiceLifetime.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddScoped<IScopedService, ScopedService>();


var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
