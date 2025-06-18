using System.Text.Json.Serialization;

namespace SpaceDisney;
public class Datos
{
    [JsonPropertyName("_id")]
    public int Id { get; set; }

    [JsonPropertyName("films")]
    public List<string> Films { get; set; }

    [JsonPropertyName("shortFilms")]
    public List<object> ShortFilms { get; set; }

    [JsonPropertyName("tvShows")]
    public List<string> TvShows { get; set; }

    [JsonPropertyName("videoGames")]
    public List<string> VideoGames { get; set; }

    [JsonPropertyName("parkAttractions")]
    public List<string> ParkAttractions { get; set; }

    [JsonPropertyName("allies")]
    public List<object> Allies { get; set; }

    [JsonPropertyName("enemies")]
    public List<object> Enemies { get; set; }

    [JsonPropertyName("sourceUrl")]
    public string SourceUrl { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("imageUrl")]
    public string ImageUrl { get; set; }

    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("__v")]
    public int __v { get; set; }
}

public class Info
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("totalPages")]
    public int TotalPages { get; set; }

    [JsonPropertyName("previousPage")]
    public string? PreviousPage { get; set; }

    [JsonPropertyName("nextPage")]
    public string NextPage { get; set; }
}

public class Disney
{
    [JsonPropertyName("info")]
    public Info Info { get; set; }

    [JsonPropertyName("data")]
    public List<Datos> Data { get; set; }
}