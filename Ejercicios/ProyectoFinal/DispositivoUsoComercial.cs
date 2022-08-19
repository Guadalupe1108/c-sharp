using System;
using System.Collections.Generic;

public class ProyectoFinal
{
    public List<Usuarios> ListadeUsuarios { get; set; }
    public List<Postres> ListadePostres { get; set; }
    public List<Clientes> ListadeClientes { get; set; }
    public List<Entrada> ListaEntrada { get; set; }
    public ProyectoFinal()
    {
        ListadePostres = new List<Postres>();
        cargarPostres();

        ListadeClientes = new List<Clientes>();
        cargarClientes();

        ListadeUsuarios = new List<Usuarios>();
        cargarUsuarios();

        ListaEntrada = new List<Entrada>();
    }


//Cargar usuarios
    private void cargarUsuarios()
    {
        Usuarios u01 = new Usuarios(1,"    María Aguilar    ",   "001");
        ListadeUsuarios.Add(u01);

        Usuarios u02 = new Usuarios(2,"    Jorge Cáceres    ",   "002");
        ListadeUsuarios.Add(u02);
        
        Usuarios u03= new Usuarios(3, "    Paco López       ",   "003");
        ListadeUsuarios.Add(u03);
        
        Usuarios u04= new Usuarios(4, "    Maryuri Cerrano  ",   "004");
        ListadeUsuarios.Add(u04);    
    }

    //Cargar postres
    public void cargarPostres()
    {
        
        Postres p01 = new Postres(1,"Tres Leches                    ",  70);
        ListadePostres.Add(p01);

        Postres p02 = new Postres(2,"Envinado Francés               ",  300);
        ListadePostres.Add(p02);

        Postres p03 = new Postres(3,"Cheese Cake                    ",  320);
        ListadePostres.Add(p03);

        Postres p04 = new Postres(4,"Choco Flan                     ",  80);
        ListadePostres.Add(p04);

        Postres p05 = new Postres(5,"Dos estaciones                 ",  360);
        ListadePostres.Add(p05);

        Postres p06 = new Postres(6,"Crepas                         ",  210);
        ListadePostres.Add(p06);

        Postres p07 = new Postres(7,"Rolles de Canela               ",  250);
        ListadePostres.Add(p07);


    }

    //Cargar clientes
    public void cargarClientes()
    {
        Clientes c01 = new Clientes(1, "Allison Smith      ", "9642-1054     ", " 0506-2000-08728");
        ListadeClientes.Add(c01);

        Clientes c02 = new Clientes(2, "Lorena Arita       ", "8856-9123     ", " 0501-1998-00967");
        ListadeClientes.Add(c02);

        Clientes c03 = new Clientes(3, "Nahum Mejía        ", "3214-2345     ", " 0502-2001-17623");
        ListadeClientes.Add(c03);

        Clientes c04 = new Clientes(4, "David Hernández    ", "2553-6483     ", " 0501-1995-32456");
        ListadeClientes.Add(c04);


    }
       //Lista de pasteles
    public void ListarPostres()
    {
        Console.Clear();
        Console.WriteLine("                        Lista de Postres         ");
        Console.WriteLine("                  Reposteria y Pasteleria Malu   ");
        Console.WriteLine("****************************************************************");
        Console.WriteLine("Código|          Postre                      |     Precio");
        Console.WriteLine("");
        
        foreach (var postres in ListadePostres)
        {
            Console.WriteLine(postres.Codigo + "   |   "+ postres.Descripcion + "      |     " + postres.Precio);
        }

        Console.ReadLine();
    }


     //Lista de clientes
    public void ListarClientes()
    {
        Console.Clear();
        Console.WriteLine("                         Lista de Clientes        ");
        Console.WriteLine("                    Reposteria y Pasteleria Malu          ");
        Console.WriteLine("******************************************************************");
        Console.WriteLine("Código|        Cliente         | Teléfono       |     Identidad    ");
        Console.WriteLine("");
        
        foreach (var clientes in ListadeClientes)
        {
            Console.WriteLine(clientes.Codigo + "     |    " + clientes.Nombre + " | " + clientes.Telefono + " | " + clientes.Identidad);
        }

        Console.ReadLine();
    }

     //Lista de usuarios
    public void ListarUsuarios()
    {
        Console.Clear();
        Console.WriteLine("                Lista de Usuarios    ");
        Console.WriteLine("          Reposteria y Pasteleria Malu      ");
        Console.WriteLine("**************************************************");
        Console.WriteLine("Código|       Usuario         | CodUsuario");
        Console.WriteLine("");
        
        foreach (var usuarios in ListadeUsuarios)
        {
            Console.WriteLine(usuarios.Codigo + "    | " + usuarios.Nombre + "  | " + usuarios.CodUsuarios);
        }

        Console.ReadLine();

    }

     //Ingresos de nueva entrada
    public void CrearEntrada()
    {
        Console.Clear();
        Console.WriteLine("                 Ingreso de Entradas                          ");
        Console.WriteLine("            Reposteria y Pasteleria Malu                          ");
        Console.WriteLine("************************************************************");
        Console.WriteLine("Digite el código de Usuario: ");
        string CodUsuarios = Console.ReadLine();

        Usuarios usuarios = ListadeUsuarios.Find(v => v.Codigo.ToString() == CodUsuarios);
        if (usuarios == null) 
        {
            Console.WriteLine("Este usuario no existe");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Usuario : " + usuarios.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el código del cliente: ");
        string codigoClientes = Console.ReadLine();

        Clientes clientes = ListadeClientes.Find(c => c.Codigo.ToString() == codigoClientes);        
        if (clientes == null)
        {
            Console.WriteLine("Este cliente no existe");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente : " + clientes.Nombre);
            Console.WriteLine("");
        }

       

        int nuevoCodigo = ListaEntrada.Count + 1;

        Entrada nuevaEntrada = new Entrada(nuevoCodigo, DateTime.Now, "San Pedro Sula" + nuevoCodigo, clientes, usuarios);
        ListaEntrada.Add(nuevaEntrada);

        while(true)
        {
            Console.WriteLine("Ingrese el código del postre: ");
            string codigoPostres = Console.ReadLine();
            Postres postres = ListadePostres.Find(p => p.Codigo.ToString() == codigoPostres);        
            if (postres == null)
            {
                Console.WriteLine("Postre no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Postre agregado:" + postres.Descripcion + "con precio de: " + postres.Precio);
                nuevaEntrada.AgregarPostres(postres);
            }

            Console.WriteLine("Desea ingresar otro postre? S/N");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("El subtotal de la venta es de: " + nuevaEntrada.Subtotal);
        Console.WriteLine("El impuesto de la venta es de: " + nuevaEntrada.Impuesto);
        Console.WriteLine("El total de la venta es de: " + nuevaEntrada.Total);
        Console.ReadLine();
    }
    
      //Reporte de entradas
    public void ListarEntrada()
    {
        Console.Clear();
        Console.WriteLine("                                                          Reporte de Entradas                                                  ");
        Console.WriteLine("                                                      Reposteria y Pasteleria Malu                                                  " );
        Console.WriteLine("****************************************************************************************************************************************************");
        Console.WriteLine("Códig. | Fecha               |Postre                          | Cant. |Precio | S.total | ISV | Total    | Cliente                 | Usuario ");
        Console.WriteLine("****************************************************************************************************************************************************");
        Console.WriteLine("");  

        foreach (var entrada in ListaEntrada)
        foreach (var final in entrada.ListaEntradaFinal)
        {
            Console.WriteLine(entrada.Codigo + " |" +entrada.Fecha + "|" +final.Postres.Descripcion +"  |  "+ final.Cantidad + "    |  " + final.Precio + "  |  "+ entrada.Subtotal + "  |  " + entrada.Impuesto + "   |   " + entrada.Total + "    |   " + entrada.Clientes.Nombre + "  | " + entrada.Usuarios.Nombre); 
            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}
