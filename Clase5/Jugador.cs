using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    internal class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;


        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni ,string nombre):this()
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni,string nombre,int totalGoles,int totalPartidos) : this(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }


        public float GetPromediosGoles()
        {
            if (this.partidosJugados != 0)
            {
                this.promedioGoles = this.totalGoles / this.partidosJugados;
            }
           
            return this.promedioGoles;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n nombre: {this.nombre}");
            sb.Append($"\n dni: {this.dni}");
            sb.Append($"\n partidosJugados: {this.partidosJugados}");
            sb.Append($"\n promedioGoles: {this.GetPromediosGoles()}");
            sb.Append($"\n totalGoles: {this.totalGoles}");

            return sb.ToString();

        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return j1.dni != j2.dni;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }
    }
}
