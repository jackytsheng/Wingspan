using System.Text.Json.Serialization;

namespace Wingspan.Model;

public class Bird
{
    [JsonPropertyName("common_name")] public string CommonName { get; init; }
    [JsonPropertyName("scientific_name")] public string ScientificName { get; init; }
    [JsonPropertyName("game_set")] public string GameSet { get; init; }
    [JsonPropertyName("ability_color")] public string AbilityColor { get; init; }

    [JsonPropertyName("ability_description")]
    public string AbilityDescription { get; init; }
}
