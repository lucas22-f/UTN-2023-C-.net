using System.Globalization;

namespace EjercicioA03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio numero A03 ";

            Console.WriteLine("Ingresa un numero para saber todos los numeros primos que hay hasta ese numero");
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Numeros primos: 0");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    
                    if (i >= 2)
                    {

                        bool bandera = false;

                        for (int j = 2; j < i; j++)
                        {
                            if (i % j == 0)
                            {
                                bandera = true;
                                break;
                            } 
                        }


                        if (!bandera)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    
                }
                
            }


        }
    }
}