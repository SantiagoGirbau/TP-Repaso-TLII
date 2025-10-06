class Tarea
{
    private static int autonum;
    private int id;
    private string? titulo;
    private string? descripcion;

    public int Id { get => id; set => id = value; }
    public string? Titulo { get => titulo; set => titulo = value; }
    public string? Descripcion { get => descripcion; set => descripcion = value; }

    private enum Estado
    {
        Pendiente,EnProgreso,Completada
    };
}