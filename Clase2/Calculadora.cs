using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public class Calculadora
    {

        public static double Calcular(int op1, int op2 , char caract)
        {

            switch (caract)
            {
                case '+': return op1 + op2;
                case '-': return op1 - op2; 
                case '*': return op1 * op2;
                case '/': 
                    if (Validar(op2))
                    {
                        return op1 / op2;
                    }
                    return double.NaN;
                    default: return double.NaN;
            }

         


        }

        private static bool Validar(int op2)
        {

            return op2 != 0;


        }

        public static void Calculator3000()
        {
            Console.Title = "Ejercicio I04";
            Console.WriteLine("ingresar 1 numeros para calcular");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar otro numero para calcular");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar operacion : + - * /");
            char op = char.Parse(Console.ReadLine());

            double res = Calculadora.Calcular(n1, n2, op);
            Console.WriteLine($"el resultado es : {res}");


        }
    }
}
