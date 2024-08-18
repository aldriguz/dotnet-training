using HttpClientFactory.Models;

namespace HttpClientFactory.Clients;

public interface IPokemonClient {
    public Task<ItemPocket> GetItemPocket(string id);
}