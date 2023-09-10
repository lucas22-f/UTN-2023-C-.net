using Clase3;


using Biblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        // EJERCICIO PROPUESTO EN CLASE : 

        //Creadora ob1 = new();
        //Creadora ob2 = new();
        //Creadora ob3 = new();
        //Creadora ob4 = new();

        //Console.WriteLine(Creadora.ObtenerCantidadObjetosCreados());
        //Console.WriteLine(ob1.ObtenerDiferencia());
        //Console.WriteLine(ob2.ObtenerDiferencia());
        //Console.WriteLine(ob3.ObtenerDiferencia());
        //Console.WriteLine(ob4.ObtenerDiferencia());



        //EJERCICIOS POST CLASE : 

        //Console.Title = "Ejercicio I01";
        //Cuenta cuenta1 = new("Lucas", 1000);

        //Console.WriteLine(cuenta1.GetCantidad());
        //Console.WriteLine(cuenta1.GetTitular());
        //Console.WriteLine(cuenta1.mostrar());
        //cuenta1.ingresar(5000);

        //Console.WriteLine(cuenta1.mostrar());

        //cuenta1.retirar(2000);

        //Console.WriteLine(cuenta1.mostrar());


        //Console.Title = "Ejercicio I02";
        //DateTime fecha = new DateTime(2000, 05, 22);

        //Persona pers = new("Lucas",fecha,"42413717");
        //Console.WriteLine(pers.Mostrar());
        //Console.WriteLine(pers.EsMayorDeEdad());


        Console.Title = "Ejercicio I03 - El ejemplo universal";

        Estudiante e1 = new("Pompin ", "2241", "Pepe")
        {
            NotaPrimerParcial = 4,
            NotaSegundoParcial = 2
        };

        Estudiante e2 = new("Dito", "3524", "Fernan")
        {
            NotaPrimerParcial = 6,
            NotaSegundoParcial = 6
        };

        Estudiante e3 = new("Figue ", "5354", "Lucas")
        {
            NotaPrimerParcial = 9,
            NotaSegundoParcial = 10
        };

        Console.WriteLine(e1.Mostrar());
        Console.WriteLine("\n\n");
        Console.WriteLine(e2.Mostrar());
        Console.WriteLine("\n\n");
        Console.WriteLine(e3.Mostrar());









    }
}