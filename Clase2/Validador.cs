using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            return (valor > min && valor < max);
            
        }


        public static void Validadores()
        {

            Console.WriteLine("Ingresar 10 numeros");
            int max = int.MinValue;
            int min = int.MaxValue;

            double suma = 0;
            double promedio;
            for (int i = 0; i < 10; i++)
            {
                int n = int.Parse(Console.ReadLine());

                if (Validar(n, -100, 100))
                {
                    if (n < min)
                    {
                        min = n;

                    }
                    else if (n > max)
                    {
                        max = n;

                    }
                    suma += n;
                }
                else
                {
                    Console.WriteLine("Error numero invalido. Debe estar entre : -100 y 100");
                }



            }
            promedio = suma / 10d;
            Console.WriteLine("Mayor: " + max);
            Console.WriteLine("Menor: " + min);
            Console.WriteLine("Promedio: " + promedio);

        }


    }
}
