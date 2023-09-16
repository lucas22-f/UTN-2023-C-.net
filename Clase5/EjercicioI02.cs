using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Clase6
{
    internal class EjercicioI02
    {
        public static void EJI02() {

            Random r = new Random();    
            List<int> lista = new List<int>();
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();

            List<int> temp = new List<int>();
            for (int i = 0; i < 20; i++) { 
            
                temp.Add(r.Next(-100, 100));
    
            }
            lista.AddRange(temp);

            foreach(int elem in temp)
            {
                cola.Enqueue(elem);
                pila.Push(elem);

            }
            Separador.MegaSeparador("Lista");
            foreach (int elem in lista)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(lista);
            Console.WriteLine("\n----------Decreciente---------");
            lista.Sort();
            lista.Reverse();
            foreach (int elem in lista)
            {
                if (elem > 0)
                {
                    Console.WriteLine(elem);
                }
            }

            Console.WriteLine("\n---------Creciente----------");
            lista.Reverse();
            foreach (int elem in lista)
            {
                if (elem < 0)
                {
                    Console.WriteLine(elem);
                }
            }





            Separador.MegaSeparador("Cola");
            foreach (int elem in cola)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(cola);

            Separador.MegaSeparador("Pila");
            foreach (int elem in pila)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine(pila);
            
        }
    }
}
