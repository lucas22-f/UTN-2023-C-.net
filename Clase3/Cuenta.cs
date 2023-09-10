using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    internal class Cuenta
    {

        // EJERCICIO I01
        private string titular;
        private double cantidad;

       
        public Cuenta(string titular, int cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }   

        public string GetTitular()
        {
            return this.titular;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public string mostrar()
        {
            return $"el titular es : {this.titular} y la cantidad es : {this.cantidad}";
        }

        public void ingresar(double ingreso)
        {
            if (ingreso > 0) { this.cantidad += ingreso;}
        }

        public void retirar(double retiro)
        {
            this.cantidad -= retiro;
        }

    }
}
