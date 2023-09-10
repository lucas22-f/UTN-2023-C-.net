using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public double CalcularNotaFinal() {

            if (this.NotaPrimerParcial > 4 && this.NotaSegundoParcial > 4)
            {
                return Estudiante.random.Next(6,10);

            }
            return -1;
        
        }
        private float CalcularPromedio() { return (this.notaPrimerParcial + this.notaSegundoParcial) / 2; }
        public string Mostrar() {

            StringBuilder sb = new($"Nombre Alumno :{this.nombre}");
            sb.Append($"\nApellido Alumno :{this.apellido}");
            sb.Append($"\nLegajo Alumno :{this.legajo}");
            sb.Append($"\nNota 1er Parcial:{this.NotaPrimerParcial}");
            sb.Append($"\nNota 2do Parcial:{this.NotaSegundoParcial}");
            sb.Append($"\nPromedio:{this.CalcularPromedio()}");
            if (this.CalcularNotaFinal() != -1) {
                sb.Append($"\nNota Final:{this.CalcularNotaFinal()}");
            }
            else
            {
                sb.Append($"\nAlumno Desaprobado.");

            }

            return sb.ToString();

        }

        public int NotaPrimerParcial
        {
            get { return this.notaPrimerParcial; }
            set { this.notaPrimerParcial = value; }

        }
        public int NotaSegundoParcial
        {
            get { return this.notaSegundoParcial; }
            set { this.notaSegundoParcial = value; }
        }







    }
}
