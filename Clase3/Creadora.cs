using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    internal class Creadora
    {
        // De clase  ->  static
        // De instancia -> no static
        private static DateTime fechaCreacionPrimerObjeto;
        private static int contadorObjetosCreados;
        private DateTime fechaCreacion;

        static Creadora()
        {
            Creadora.fechaCreacionPrimerObjeto = DateTime.Now;
            Creadora.contadorObjetosCreados = 0;
        }

        public Creadora() 
        {
            this.fechaCreacion = DateTime.Now;
            Creadora.contadorObjetosCreados++;
        }

        public static int ObtenerCantidadObjetosCreados() 
        { 
            return Creadora.contadorObjetosCreados; 
        }

        public string ObtenerDiferencia()
        {
            TimeSpan s = fechaCreacion - Creadora.fechaCreacionPrimerObjeto;

            return s.TotalMilliseconds.ToString();
        }


    }
}
