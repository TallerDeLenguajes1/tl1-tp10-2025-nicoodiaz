using System.Text.Json;
using SpaceDisney;

namespace SpaceConsumoDisney;

class ConsumoDisney
{
    //Metodo para deserializar 
    public static async Task<Disney> GetInfoDisney()
    {
        var url = "https://api.disneyapi.dev/character";
        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Disney listadoDisney = JsonSerializer.Deserialize<Disney>(responseBody);
            return listadoDisney;
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine("Problemas de acceso a la API");
            Console.WriteLine("Message :{0} ", e.Message);
            return null;
        }
    }
    
    //Metodo para serializar
}