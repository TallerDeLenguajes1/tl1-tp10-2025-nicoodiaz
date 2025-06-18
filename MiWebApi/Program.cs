using SpaceConsumoDisney;
using System.Text.Json;
using System.IO;
using SpaceDisney;

ConsumoDisney ConsumoDisney = new ConsumoDisney();

//Obtengo la peticion
var listDisney = await ConsumoDisney.GetInfoDisney();

string nombreArchivo = "disney.json";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Nombre {listDisney.Data[i].Name} | ID: {listDisney.Data[i].Id} | Aliados: {listDisney.Data[i].CreatedAt}");
}


//Serializo la lista de tareas, para que sea un string y luego poder escribirlas dentro del archivo
string DisneyJson = JsonSerializer.Serialize(listDisney);
//Escribo en un archivo json, de una manera distinta a la hecha en el ejercicio 1
File.WriteAllText(nombreArchivo, DisneyJson);