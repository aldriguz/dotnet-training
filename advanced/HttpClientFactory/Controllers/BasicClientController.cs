using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientFactory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BasicClientController : ControllerBase 
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<BasicClientController>  _logger;

    public BasicClientController(IHttpClientFactory httpClientFactory, ILogger<BasicClientController> logger)
    {
        _httpClient = httpClientFactory.CreateClient();
        _logger = logger;
    }

    [HttpGet("PokemonBerry")]
    public async Task<IActionResult> GetPokemonByName(string name)
    {
        _httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/berry/");
        var httpResponseMessage = await _httpClient.GetAsync(name);
        var response = await httpResponseMessage.Content.ReadAsStringAsync();
        
        _logger.LogInformation(response);
        
        return Ok(response);
    }
}