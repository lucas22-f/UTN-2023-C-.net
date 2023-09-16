using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    internal class EjercicioI01
    {

        public static void EJI01()
        {
            Random random = new Random();

            int[] arr = new int[20];


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-100, 100);
            }
            Console.WriteLine("\n---------- Array Random ,---------");
            foreach (int i in arr)
            {
                Console.WriteLine(i);

            }


            Console.WriteLine("\n----------Decreciente---------");
            Array.Sort(arr);
            Array.Reverse(arr);
            foreach(int elem in arr)
            {
                if (elem > 0)
                {
                    Console.WriteLine(elem);
                }
            }

            Console.WriteLine("\n---------Creciente----------");
            Array.Reverse(arr);
            foreach (int elem in arr)
            {
                if (elem < 0)
                {
                    Console.WriteLine(elem);
                }
            }

        }
    }
}
