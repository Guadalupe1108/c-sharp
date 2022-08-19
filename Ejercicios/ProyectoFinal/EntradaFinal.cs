public class EntradaFinal
{
    public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public Postres Postres { get; set; }

    public EntradaFinal(int codigo, int cantidad, Postres postres)
    {
        Codigo = codigo;
        Cantidad = cantidad;
        Postres = postres;
        Precio = postres.Precio;
    }
}