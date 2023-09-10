using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class Factorial
    {

        public static int CalcularFactorial(int n)
        {
           
            int res = 1;
            for (int i = n; i >= 1;i--)
            {
                res *= i;
                

            }
            Console.Title = "Ejercicio A01";
            Console.WriteLine(res);
            return res;
        }
    }
}
