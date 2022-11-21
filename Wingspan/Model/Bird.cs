using System.Text.Json.Serialization;
using HotChocolate;

namespace Wingspan.Model;

public class Bird
{
    [GraphQLName("common_name")]
    [JsonPropertyName("common_name")]
    public string CommonName { get; init; }

    [GraphQLName("scientific_name")]
    [JsonPropertyName("scientific_name")]
    public string ScientificName { get; init; }

    [GraphQLName("game_set")]
    [JsonPropertyName("game_set")]
    public string GameSet { get; init; }

    [GraphQLName("ability_color")]
    [JsonPropertyName("ability_color")]
    public string AbilityColor { get; init; }

    [GraphQLName("ability_description")]
    [JsonPropertyName("ability_description")]
    public string AbilityDescription { get; init; }

    [GraphQLName("bird_information")]
    [JsonPropertyName("bird_information")]
    public string BirdInformation { get; init; }

    [GraphQLName("is_predator")]
    [JsonPropertyName("is_predator")]
    public bool IsPredator { get; init; }

    [GraphQLName("is_flocking")]
    [JsonPropertyName("is_flocking")]
    public bool IsFlocking { get; init; }

    [GraphQLName("provide_bonus_card")]
    [JsonPropertyName("provide_bonus_card")]
    public bool ProvideBonusCard { get; init; }

    [GraphQLName("bird_points")]
    [JsonPropertyName("bird_points")]
    public int BirdPoints { get; init; }

    [GraphQLName("nest_type")]
    [JsonPropertyName("nest_type")]
    public string NestType { get; init; }

    [GraphQLName("egg_capacity")]
    [JsonPropertyName("egg_capacity")]
    public string EggCapacity { get; init; }

    [GraphQLName("wingspan")]
    [JsonPropertyName("wingspan")]
    public string Wingspan { get; init; }

    [GraphQLName("habitat_type")]
    [JsonPropertyName("habitat_type")]
    public HabitatType Habitat { get; init; }
}

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HabitatType
{
    Forest,
    Grassland,
    Wetland,
}
