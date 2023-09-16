using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    internal class Equipo
    {
        private int cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;


        private Equipo()
        {
            this.jugadores = new List<Jugador>();
           
        }

        public Equipo(short cantidad,string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }


        public static bool operator +(Equipo e , Jugador j)
        {
            if ((e.jugadores.Count < e.cantidadDeJugadores) && !e.jugadores.Contains(j))
            {   
                    e.jugadores.Add(j);

                    
                    Console.WriteLine("\n" + j.MostrarDatos());
                    
                    return true;
            }
            else
            {
                return false;
            }
        }
    }
}
