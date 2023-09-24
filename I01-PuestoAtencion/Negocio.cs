using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I01_PuestoAtencion
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }

            set
            {
                if(!(this == value))
                {
                    this.clientes.Enqueue(value);
                }
                else
                {
                    Console.WriteLine("error, cliente ya existe");
                }
            }
        }

        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
            
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        public static bool operator +(Negocio n,Cliente c)
        {
            if (!(n == c))
            {
                n.clientes.Enqueue(c);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool operator ==(Negocio n, Cliente c)
        {
            bool res = false;
            foreach (Cliente cl in n.clientes)
            {
                if ((cl == c))
                {
                    res = true;
                }
                else
                {
                    res = false;
                }

            }
            return res;
        }

        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            
            return false;
            
            
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n==c);
        }

        public int ClientesPendientes
        {
            get { return this.clientes.Count; }
        }
    }

}
