using System.Text.Json;
using EspacioTareas;
using SpaceConsumoTareas;
using SpaceManejoArchivos;
//Creo instancias para poder usar los metodos y clases de cada namespace
ConsumoTareas ConsumoTareas = new ConsumoTareas();
ManejoArchivos misArchivos = new ManejoArchivos();

//Obtengo la peticion de las tareas en una lista
var listTareas = await ConsumoTareas.GetTareas();

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("-------------------");
Console.WriteLine("Tareas Pendientes");
Console.BackgroundColor = ConsoleColor.Cyan;

//Muestro las tareas pendientes
foreach (var item in listTareas)
{
    if (!item.Completed)
    {
        Console.WriteLine($"Titulo: {item.Title} | Estado: {item.Completed}");
    }
}
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("------------");
Console.WriteLine("Tareas Completadas");
Console.BackgroundColor = ConsoleColor.DarkRed;

//Muestro las tareas completadas
foreach (var item in listTareas)
{
    if (item.Completed)
    {
        Console.WriteLine($"Titulo: {item.Title} | Estado: {item.Completed}");
    }
}

//Serializo la lista de tareas, para que sea un string y luego poder escribirlas dentro del archivo
string alumnosJson = JsonSerializer.Serialize(listTareas);
string nombreDelArchivo = "tareas.json";

//Llamo la funcion, para poder guardar y escribir en el archivo json
misArchivos.GuardarArchivoTexto(nombreDelArchivo, alumnosJson);


