using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_PuestoAtencion
{

    public enum Puesto
    {
        Caja1,
        Caja2
    }


    internal class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        public static int NumeroActual { 
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }


        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto p)
        {
            this.puesto = p;
        }


        public  bool Atender(Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }

    


    }
}
