using System.Text.Json;
using EspacioTareas;

namespace SpaceConsumoTareas;

class ConsumoTareas
{
    //Metodo para deserializar 
    public static async Task<List<Tareas>> GetTareas()
    {
        var url = "https://jsonplaceholder.typicode.com/todos/";
        try
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<Tareas> listadoTareas = JsonSerializer.Deserialize<List<Tareas>>(responseBody);
            return listadoTareas;
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