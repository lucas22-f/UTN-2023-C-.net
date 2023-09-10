using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    public class CalculadoraDeAreas
    {
        public static double CalcularAreaCuadrado(double longitudLado) {
            return longitudLado * longitudLado;
        }
        public static double CalcularAreaTriangulo(double baseT ,double altura) { 
            return (baseT * altura) / 2;
        }
        public static double CalcularAreaCirculo(double radio) {
            return Math.PI * (radio * radio);
        }

        public static void PedirAreas()
        {
            Console.Title = "EJERCICIO I06";
            Console.WriteLine("ingresar numeros para calcular area Cuadrado");
            int ladoC = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculadoraDeAreas.CalcularAreaCuadrado(ladoC));


            Console.WriteLine("ingresar numeros  para calcular area Triangulo");
            int basea = int.Parse(Console.ReadLine());
            int altura = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculadoraDeAreas.CalcularAreaTriangulo(basea, altura));

            Console.WriteLine("ingresar radio para calcular area Circulo");
            int radio = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculadoraDeAreas.CalcularAreaCirculo(radio));
        }

    }
}
