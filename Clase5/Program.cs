using Clase6;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {

        //EjercicioI01.EJI01();

        //EjercicioI02.EJI02();

        Equipo equip = new Equipo(2,"los pepes");

        Jugador j1 = new Jugador(123, "pepe1");
        Jugador j2 = new Jugador(222, "pepe2",10,2);
        Jugador j3 = new Jugador(333, "pepe3");
        Console.WriteLine(new Jugador(223, "xd") != new Jugador(222, "xd"));
        Jugador[] jugadore = new Jugador[] { j1, j2, j3 };
        for (int i = 0; i < 3; i++)
        {
            if(equip + jugadore[i])
            {
                Console.WriteLine("Jugador agregado ");

            }
            else
            {
                Console.WriteLine("Jugador NO agregado . max alcanzado.");
            }
        }







    }
}