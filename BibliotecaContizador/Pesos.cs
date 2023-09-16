using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Pesos
    {
        private double cantidad;
        private static double cotzRespectoDolar;


        static Pesos()
        {
            Pesos.cotzRespectoDolar = 102.65;
        }


        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotizacion()
        {
            return Pesos.cotzRespectoDolar;
        }




    }
}
