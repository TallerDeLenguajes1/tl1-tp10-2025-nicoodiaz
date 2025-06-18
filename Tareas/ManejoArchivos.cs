namespace SpaceManejoArchivos;
//Clase para poder escribir el archivo json
class ManejoArchivos
{
    public void GuardarArchivoTexto(string nombreArchivo, string datos) //Recibo dos parametros, nombre del archivo donde lo quiero guardar y los datos que quiero guardar (Estos datos, ya tienen que estar serializados)
    {
        //Using sirve para que cuando se termine el scope, se pueda liberar automaticamente la memoria
        using (var archivo = new FileStream(nombreArchivo, FileMode.Create))//Linea para poder acceder al archivo, crearlo si no existe y sino, reemplazarlo
        {
            using (var strWriter = new StreamWriter(archivo)) //Crea una instancia de StreamWriter, para poder acceder a sus metodos y escribir en el archivo
            {
                strWriter.WriteLine(datos); //Toma lo de la variable datos y la escribe sobre el archivo
                strWriter.Close(); //Para poder cerrar el streamWriter y si despues lo quiero abrir nuevamente, no me tira error
            }
        }
    }
}