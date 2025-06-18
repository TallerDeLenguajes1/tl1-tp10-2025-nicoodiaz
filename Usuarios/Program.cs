using System.Text.Json;
using SpaceConsumoUsuarios;

ConsumoUsuarios ConsumoUsuarios = new ConsumoUsuarios();

//Obtengo la lista de la peticion ya deserealizada
var listUsuarios = await ConsumoUsuarios.GetInfoUsuarios();

//Muestro solo los primeros 5 usuarios
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Nombre: {listUsuarios[i].Name} | E-mail: {listUsuarios[i].Email} | Domicilio: {listUsuarios[i].Address}");
}