using Refit;

namespace HttpClientFactory.Clients;

public interface IPokedexClient {

    [Get("/{id}")]
    public Task<Pokemon> GetPokemonAsync(string id);
}