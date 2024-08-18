using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientFactory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CommonClientController : ControllerBase 
{
    private readonly HttpClient _httpClient = new HttpClient();
    private readonly ILogger<CommonClientController>  _logger;

    public CommonClientController(ILogger<CommonClientController> logger)
    {
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