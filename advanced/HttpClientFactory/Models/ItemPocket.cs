using System.Text.Json.Serialization;

namespace HttpClientFactory.Models;

public class ItemPocket {
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";
}