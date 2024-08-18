using System.Text.Json.Serialization;

public class Pokemon {
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = "";

    [JsonPropertyName("order")]
    public int Order { get; set; }
}