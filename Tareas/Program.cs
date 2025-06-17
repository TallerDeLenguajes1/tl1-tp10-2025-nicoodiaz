using System.Text.Json;
using EspacioTareas;
using SpaceConsumoTareas;
using SpaceManejoArchivos;
ConsumoTareas ConsumoTareas = new ConsumoTareas();
ManejoArchivos misArchivos = new ManejoArchivos();

var listTareas = await ConsumoTareas.GetTareas();

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("-------------------");
Console.WriteLine("Tareas Pendientes");
Console.BackgroundColor = ConsoleColor.Cyan;

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
foreach (var item in listTareas)
{
    if (item.Completed)
    {
        Console.WriteLine($"Titulo: {item.Title} | Estado: {item.Completed}");
    }
}

string alumnosJson = JsonSerializer.Serialize(listTareas);
string nombreDelArchivo = "tareas.json";

misArchivos.GuardarArchivoTexto(nombreDelArchivo, alumnosJson);


