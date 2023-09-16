using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;


        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }


        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }   


        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }


    }
}
