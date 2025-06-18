using System.Text.Json;
using EspacioUsuarios;

namespace SpaceConsumoUsuarios;

class ConsumoUsuarios
{
    //Metodo para deserializar 
    public static async Task<List<Usuarios>> GetInfoUsuarios()
    {
        var url = "https://jsonplaceholder.typicode.com/users";
        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Usuarios> listadoUsuarios = JsonSerializer.Deserialize<List<Usuarios>>(responseBody);
            return listadoUsuarios;
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