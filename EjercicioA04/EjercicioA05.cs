using System;


namespace Ejercicios
{
    public class EjercicioA05
    {

       public static void CentrosNumericos()
        {
            Console.WriteLine("ingresa un numero");
            int numero = int.Parse(Console.ReadLine());

            int grupo1 = 0;

            int grupo2 = 0;


            for (int i = 1; i <numero; i++)
            {
                grupo1 += (i-1);

                for (int j = i+1; j < 2*i; j++)
                {
                    grupo2 += j;
                    if (grupo1 == grupo2)
                    {
                        Console.WriteLine($"existe un centro numerico en:{i}");
                    }
                    
                }
                grupo2 = 0;
            }

           




        }





    }
}
