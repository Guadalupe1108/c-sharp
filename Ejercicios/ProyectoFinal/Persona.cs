using System;
public class Persona

{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public string Telefono { get; set; }
    public string Identidad { get; set; }


    public void EnviarAviso()

    {
        Console.WriteLine("Notificación enviada a: " + Nombre);
    }
}