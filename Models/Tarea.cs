public class Tarea
{
    private static int autonum;
    private int id;
    private string? titulo;
    private string? descripcion;
    Estado estado;

    Tarea(string titulo, string descripcion, Estado estado)
    {
        this.titulo = titulo;
        this.descripcion = descripcion;
        this.estado = estado;
    }

    public int Id { get => id; set => id = value; }
    public string? Titulo { get => titulo; set => titulo = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }
    private Estado Estado1 { get => estado; set => estado = value; }

    private enum Estado
    {
        Pendiente,EnProgreso,Completada
    };
}