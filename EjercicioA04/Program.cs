using Ejercicios;

namespace EjercicioA04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio A04
            // NrosPerfectos();


            //Ejercicio A05
            //EjercicioA05.CentrosNumericos();


            Ejercicios.Class1.Dibujo();



        }

        public static void NrosPerfectos() {

            Console.Title = "Ejercicio A04";
            int numero = 1;
            int contador = 0;
            while (contador < 4)
            {
                int sumaDivisores = 0;
                for (int i = 1; i < numero; i++)
                {

                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                    }

                }
                if (sumaDivisores == numero)
                {
                    Console.WriteLine(numero);
                    contador++;
                }
                numero++;
            }


        }
            


        }
    }
