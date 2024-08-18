using HttpClientFactory.Clients;
using Refit;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddHttpClient("PokemonItem", httpClient => 
{
    httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/item/");
});
builder.Services.AddHttpClient("PokemonType", httpClient => 
{
    httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/type/");
});
builder.Services.AddHttpClient<IPokemonClient, PokemonClient>();
builder.Services.AddRefitClient<IPokedexClient>()
    .ConfigureHttpClient( client => {
        // Set the base address of the named client.
        client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();