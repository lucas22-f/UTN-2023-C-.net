internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Ejercicio A02";
        Console.WriteLine("ingresa un numero > 0 ");

        int n = int.Parse(Console.ReadLine());


        while (n < 0)
        {
            Console.WriteLine("ERROR. Reingresar numero");
            n = int.Parse(Console.ReadLine());

        }

        double cuadrado = Math.Pow(n, 2);
        double cubo = Math.Pow(n, 3);

        Console.WriteLine($"cuadrado del numero: {cuadrado}");
        Console.WriteLine($"cubo del numero :{cubo}");
    }


}
