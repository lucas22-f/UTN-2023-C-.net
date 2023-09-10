internal class Program
{
    private static void Main(string[] args)

    {
        Console.Title = "Ejercicio A01";
        Console.WriteLine("Ingrese valores para 5 numeros");
        double n = 0;
        bool flag = true;
        double mayor = 0;
        double menor = 0;
        double sum = 0;
        double promedio;

        for (int i = 0; i < 5; i++)
        {
            n = double.Parse(Console.ReadLine());

            if (flag || n != 0 && n < menor)
            {
                menor = n;
                flag = false;
            }
            else if (n > mayor)
            {
                mayor = n;
            }
            sum += n;
        }

        Console.WriteLine(sum);
        promedio = sum / 5d;

        Console.WriteLine($"el mayor es: {mayor}");
        Console.WriteLine($"el menor es: {menor}");
        Console.WriteLine($"el promedio es: {promedio}");

    }

    }