
using System.Text.Json;
public class AccesoADatos
{
    private string? rutaDeAcceso;

    public List<Tarea> leerDatos()
    {
        var textoTareas = File.ReadAllText(rutaDeAcceso);
        var tareas = JsonSerializer.Deserialize<List<Tarea>>(textoTareas);
        return tareas;
    }

    public bool guardarDatos(List<Tarea> tareas)
    {

        string jsonString = JsonSerializer.Serialize(tareas, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText("Pedidos.json", jsonString);

        if (jsonString != null)
        {
            return true;
        }else
        {
            return false;
        }

    }

}