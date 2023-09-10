using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public class Tablas
    {

        public static string CalcularTabla(int n)
        {
            StringBuilder sb = new StringBuilder();

            Console.Title = "Ejercicio I05";
            Console.WriteLine($"tabla del numero : {n}");
            for(int i = 1; i < 9; i++)
            {
                sb.Append($"{n} * {i}  = {n*i}");
                sb.Append("\n");
            }

            return sb.ToString();

        }
    }
}
