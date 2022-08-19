public class Clientes: Persona
{
    public double Saldo { get; set; }
    public Clientes(int codigo, string nombre, string telefono, string identidad)
    {
        Codigo = codigo;
        Nombre = nombre;
        Telefono = telefono;
        Identidad = identidad;
    }
}