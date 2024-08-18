using Microsoft.AspNetCore.Mvc;

namespace HttpClientFactory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NamedClientController : ControllerBase 
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly ILogger<CommonClientController>  _logger;

    public NamedClientController(ILogger<CommonClientController> logger, IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory ?? throw new ArgumentNullException();
        _logger = logger;
    }

    [HttpGet("PokemonItem")]
    public async Task<IActionResult> GetPokemonItemByName(string name)
    {
        var httpClient = _httpClientFactory.CreateClient("PokemonItem");
        
        var httpResponseMessage = await httpClient.GetAsync(name);
        var response = await httpResponseMessage.Content.ReadAsStringAsync();
       
        _logger.LogInformation(response);
        
        return Ok(response);
    }

    [HttpGet("PokemonType")]
    public async Task<IActionResult> GetPokemonTypeByName(string name)
    {
        var httpClient = _httpClientFactory.CreateClient("PokemonType");
        
        var httpResponseMessage = await httpClient.GetAsync(name);
        var response = await httpResponseMessage.Content.ReadAsStringAsync();
       
        _logger.LogInformation(response);
        
        return Ok(response);
    }
}