using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;





        public Cosa()
        {
            this.entero = 10;
            this.cadena = "sin valor";
            this.fecha = DateTime.Now;
        }

        public Cosa(string cad):this()
        {
            this.cadena = cad;
        }
        
        public Cosa(int n , string cad) : this(cad)
        {
            this.entero = n;
        }

        public Cosa(DateTime d, int n, string cad) : this(n, cad)
        {
            this.fecha = d;
        }




        public void EstablecerValor(int numero)
        {
            this.entero = numero;

        }

        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }

        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }


        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder($"numero : {this.entero}");
            sb.AppendLine($"\ncadena: {this.cadena}");
            sb.AppendLine($"fecha: {this.fecha}");


            return sb.ToString();
                 
        }


        public static string Mostrar(Cosa cos)
        {
            return cos.Mostrar();
        }

    }
}
