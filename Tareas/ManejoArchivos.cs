namespace SpaceManejoArchivos;
class ManejoArchivos
{
    public void GuardarArchivoTexto(string nombreArchivo, string datos)
    {
        using (var archivo = new FileStream(nombreArchivo, FileMode.Create))
        {
            using (var strWriter = new StreamWriter(archivo))
            {
                strWriter.WriteLine(datos);
                strWriter.Close();
            }
        }
    }
}