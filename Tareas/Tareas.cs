using System.Text.Json.Serialization;

namespace EspacioTareas;
//Clase con la estructura de datos que quiero serializar o deserializar
public class Tareas
{
    [JsonPropertyName("userId")]
    public int UserId { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("completed")]
    public bool Completed { get; set; }
}
