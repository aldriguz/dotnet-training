using ServiceLifetime.Interfaces;
using ServiceLifetime.Service;

var builder = WebApplication.CreateBuilder(args);

// add services to container
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();
builder.Services.AddScoped<IScopedService, ScopedService>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
