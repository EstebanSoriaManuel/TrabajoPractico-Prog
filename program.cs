using System;
class Program
{
    static List<Coordinadores> listaCoordinadores = new list<Coordinadores>();
    static List<Voluntario> listaVoluntarios = new list<Voluntario>();

    static void Main()
    {
        Console.WriteLine("Organizaciòn Solidaria");
        int opcion;

        do
        {
        Console.WriteLine(@"Ingresa que quieres hacer:
        1.Registrar voluntario
        2.Registrar coordinador
        3.Mostrar información
        4.Salir");
        opcion = int.Parse(Console.ReadLine());

        switch(opcion)
        {
            case 1:
                RegistrarVoluntario();
                break;

            case 2:
                RegistrarCoordinador();
                break;
            
            case 3: 
                MostrarInformacion();
                break;
            
            case 4:
                return;
            
            default:
                Console.WriteLine("Opción inválida.");
                break;
        }
        } while(opcion != 4);

    }



    static void RegistrarVoluntario()
    {
        Console.WriteLine("Ingrese el nombre del voluntario:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el dni del voluntario:");
        string dni = Console.ReadLine();

        Console.WriteLine("Ingrese las horas trabajadas del voluntario:");
        double horasTrabajadas = double.Parse(Console.ReadLine());

        Voluntario voluntario1 = new Voluntario(nombre,dni,horasTrabajadas);
        listaVoluntarios.Add(voluntario1);
        Console.WriteLine("Se registró el voluntario con éxito.");
    }



    static void RegistrarCoordinador()
    {
        List<string> areasAsignadas = new List<string>();


        Console.WriteLine("Ingrese el nombre del coordinador:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese el dni del coordinador:");
        string dni = Console.ReadLine();

        Console.WriteLine("Ingrese la cantidad de áreas que desee agregar:");
        int cantidadAreas = int.Parse(Console.ReadLine());

        for(int i = 0; i < cantidadAreas ; i++)
        {
            Console.WriteLine("Ingrese las áreas asignadas del coordinador:");
            areasAsignadas.Add(Console.ReadLine());
        }

        Console.WriteLine("Ingrese la cantidad de voluntarios que tendrá a cargo el coordinador:");
        int voluntariosACargo = int.Parse(Console.ReadLine());


        Coordinador coordinador1 = new Coordinador(nombre, dni, areasAsignadas, voluntariosACargo);
        listaCoordinadores.Add(coordinador1);
        Console.WriteLine("Se registró el coordinador con éxito.");
        
    }



    static void MostrarInformacion()
    {
        Console.WriteLine(@"De quén quieres ver la información?
        1.Voluntarios
        2.Coordinadores");
        int opcion = int.Parse(Console.ReadLine());

        if(opcion == 1)
        {
            Console.WriteLine("Informacion de voluntarios:");
            foreach (Voluntario v in listaVoluntarios)
            {
                Console.WriteLine(v.MostrarInformacion());
            }
        }

        else if(opcion == 2)
        {
            Console.WriteLine("Informacion de coordinadores:");
            foreach (Coordinador c in listaCoordinadores)
            {
                Console.WriteLine(c.MostrarInformacion());
            }
        }
        
        else
        {
            Console.WriteLine("Opcion inválida.");
            return;
        }
    }

}