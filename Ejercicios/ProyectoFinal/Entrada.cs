using System;
using System.Collections.Generic;

public class Entrada
{
    public int Codigo { get; set; }
    public DateTime Fecha { get; set; }
    public string NumerodeOrden { get; set; }
    public Clientes Clientes { get; set; }
    public Usuarios Usuarios { get; set; }
    public List<EntradaFinal> ListaEntradaFinal { get; set; }
    public double Total { get; set; }
    public double Subtotal { get; set; }
    public double Impuesto { get; set; }

    public Entrada(int codigo, DateTime fecha, string numeroOrden, Clientes clientes, Usuarios usuarios)
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numeroOrden;
        Clientes = clientes;
        Usuarios = usuarios;
        ListaEntradaFinal = new List<EntradaFinal>();
    }

    public void AgregarPostres(Postres postres)
    {
        int nuevoCodigo = ListaEntradaFinal.Count + 1;
        int cantidad = 1;

        EntradaFinal o = new EntradaFinal(nuevoCodigo, 1, postres);
        ListaEntradaFinal.Add(o);

       
        Subtotal += cantidad * postres.Precio;
        Impuesto+= Subtotal * 0.15;
        Total += Subtotal + Impuesto;

    }
}