using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    internal class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;


        static Euro()
        {
            Euro.cotzRespectoDolar = 1.17;
        }


        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }


        public double GetCantidad()
        {
            return this.cantidad;
        }

        public double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.GetCantidad());
        }

        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Dolar d)
        {
            return e == d;
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e, Pesos p)
        {
            return e == p;
        }

        public static bool operator !=(Euro e, Euro e2)
        {
            return !(e == e2);
        }

        public static bool operator ==(Euro e, Euro e2)
        {
            return e == e2;
        }


        public static Euro operator - (Euro e,Pesos p)
        {
            double valor1 = e.GetCantidad() * Euro.cotzRespectoDolar;
            double valor2 = p.GetCantidad() / p.GetCotizacion();
            double resta = valor1 - valor2;

          
            return new Euro(resta / e.GetCotizacion()).GetCantidad();
        }

        public static Euro operator - (Euro e, Dolar d)
        {
            double valor1 = e.GetCantidad() * Euro.cotzRespectoDolar;
            double valor2 = d.GetCantidad() * d.GetCotizacion();

            
            return new Euro((valor1 - valor2) /e.GetCotizacion()).GetCantidad();
        }

        public static Euro operator + (Euro e, Dolar d)
        {
            double valor1 = e.GetCantidad() * Euro.cotzRespectoDolar;
            double valor2 = d.GetCantidad() * d.GetCotizacion();

            return new Euro((valor1 + valor2) / e.GetCotizacion()).GetCantidad();
        }

        public static Euro operator + (Euro e, Pesos p)
        {
            double valor1 = e.GetCantidad() * Euro.cotzRespectoDolar;
            double valor2 = p.GetCantidad() / p.GetCotizacion();

            return new Euro((valor1 + valor2 ) / e.GetCotizacion()).GetCantidad();
        }






    }
}
