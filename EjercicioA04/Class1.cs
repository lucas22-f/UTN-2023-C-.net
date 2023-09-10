using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Class1
    {
        public static void Dibujo()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i*2-1; j++)
                {
                    Console.Write("*");
                }
             
                Console.WriteLine();
            }    


        }
    }
}
