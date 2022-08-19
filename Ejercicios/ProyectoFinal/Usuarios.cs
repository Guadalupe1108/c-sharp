public class Usuarios: Persona
{
    public string CodUsuarios { get; set; }

    public Usuarios(int codigo, string nombre, string codUsuarios)
    {
        Codigo = codigo;
        Nombre = nombre;
        CodUsuarios = codUsuarios;
    }
}