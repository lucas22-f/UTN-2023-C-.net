internal class Program
{
    private static void Main(string[] args)

    {

        Console.Title = "Ejercicio nro 1";
        Console.WriteLine("Hello, World!");
        Console.WriteLine("ingresa tu nombre");
        string nombre = Console.ReadLine();
        Console.WriteLine("ingresa edad");
        int edad = int.Parse(Console.ReadLine());

        Console.WriteLine($"edad : {edad} , nombre : {nombre}");
    }
}