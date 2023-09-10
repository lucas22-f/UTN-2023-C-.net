using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private string dni;


        public Persona(string nombre, DateTime fechaNacimiento, string dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return this.fechaNacimiento; }
            set { this.fechaNacimiento = value; }
        }

        public string Dni
        {
            get { return this.dni; }
            set{ this.dni = value; }
        }

        private int CalcularEdad()
        {
            return DateTime.Now.Year - this.fechaNacimiento.Year;
        }

        public string Mostrar()
        {
            return $"nombre: {this.Nombre}\ndni:{this.Dni}\nfechaNacimiento: {this.FechaNacimiento.ToString("dd/MM/yyyy")}\nedad actual: {this.CalcularEdad()}";
        }

        public string EsMayorDeEdad()
        {
            if( this.CalcularEdad() < 18) { return "es menor"; }
            return "es mayor";
        }
        
    }
}
