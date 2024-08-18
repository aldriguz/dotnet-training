using HttpClientFactory.Models;
using System.Text.Json;

namespace HttpClientFactory.Clients;
public class PokemonClient : IPokemonClient {
    private readonly HttpClient _client;
    public PokemonClient(HttpClient client) 
    {
        _client = client;
        ConfigureClient();
    }

    public async Task<ItemPocket> GetItemPocket(string id)
    {
        var httpResponseMessage = await _client.GetAsync(id);
        var response = await httpResponseMessage.Content.ReadAsStringAsync();
        var itemPocket = JsonSerializer.Deserialize<ItemPocket>(response);
        return itemPocket;
    }

    private void ConfigureClient()
    {
        _client.BaseAddress = new Uri("https://pokeapi.co/api/v2/item-pocket/");
    }
}