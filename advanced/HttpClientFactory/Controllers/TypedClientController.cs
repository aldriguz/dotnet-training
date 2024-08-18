using HttpClientFactory.Clients;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientFactory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TypedClientController : ControllerBase {
    private readonly IPokemonClient _client;
    private readonly ILogger<TypedClientController> _logger;

    public TypedClientController(IPokemonClient client, ILogger<TypedClientController> logger)
    {
        _client = client;
        _logger = logger;
    }

    [HttpGet("PokemonPocket")]
    public async Task<IActionResult> GetItemPocket(string id)
    {
        var itemPocket = await _client.GetItemPocket(id);
        return Ok(itemPocket);
    }
}