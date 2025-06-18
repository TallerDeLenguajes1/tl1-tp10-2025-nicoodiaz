using System.Text.Json.Serialization;

namespace EspacioUsuarios;

//Clase para la direccion
public class Address
{
    [JsonPropertyName("street")]
    public string Street { get; set; }

    [JsonPropertyName("suite")]
    public string Suite { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("zipcode")]
    public string Zipcode { get; set; }

    [JsonPropertyName("geo")]
    public Geo Geo { get; set; }
}

//Clase para la compania
public class Company
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("catchPhrase")]
    public string CatchPhrase { get; set; }

    [JsonPropertyName("bs")]
    public string Bs { get; set; }
}

//Clase para la locacion
public class Geo
{
    [JsonPropertyName("lat")]
    public string Lat { get; set; }

    [JsonPropertyName("lng")]
    public string Lng { get; set; }
}

//Clase principal, donde se declaran las demas clases como variables
public class Usuarios
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("address")]
    public Address Address { get; set; }

    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("website")]
    public string Website { get; set; }

    [JsonPropertyName("company")]
    public Company Company { get; set; }
}