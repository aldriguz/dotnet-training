using HttpClientFactory.Clients;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientFactory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeneratedClientController : ControllerBase {

    private readonly IPokedexClient _client;

    public GeneratedClientController(IPokedexClient client)
    {
        _client = client;
    }

    [HttpGet]
    public async Task<IActionResult> GetPokemon(string id) 
    {
        var pokemon = await _client.GetPokemonAsync(id);
        return Ok(pokemon);

    }
}