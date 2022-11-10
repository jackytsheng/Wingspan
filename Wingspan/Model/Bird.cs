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

    [JsonPropertyName("bird_information")] public string BirdInformation { get; init; }
    [JsonPropertyName("is_predator")] public bool IsPredator { get; init; }
    [JsonPropertyName("is_flocking")] public bool IsFlocking { get; init; }

    [JsonPropertyName("provide_bonus_card")]
    public bool ProvideBonusCard { get; init; }

    [JsonPropertyName("bird_points")] public int BirdPoints { get; init; }
    [JsonPropertyName("nest_type")] public string NestType { get; init; }
    [JsonPropertyName("egg_capacity")] public string EggCapacity { get; init; }
    [JsonPropertyName("wingspan")] public string Wingspan { get; init; }
    [JsonPropertyName("habitat")] public HabitatType Habitat { get; init; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HabitatType
{
    Forest,
    Grassland,
    Wetland,
}
