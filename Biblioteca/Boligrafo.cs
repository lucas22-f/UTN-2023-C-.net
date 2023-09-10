using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Boligrafo
    {

        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor getColor() { return this.color; }
        public void setColor(ConsoleColor color) { this.color = color; }
        public short getTinta() { return this.tinta; }

        private void setTinta(short tinta)
        {
            if (this.tinta >= 0 && this.tinta <= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }
        }

        public void Recargar()
        {
            this.setTinta(100);
        }

        public bool Pintar(short gasto, out string dibujo) // utilizamos un parametro de salida 
                                                           // en este caso es el parametro "dibujo"
            
        {
            dibujo = "";
            
            while(this.tinta > 0 && gasto > 0) // calculamos el gasto de los respectivos niveles de tinta..
            {                                   // y tambien el gasto de las veces ya gastadas...
                gasto--;
                this.setTinta(-1);
                dibujo += "*";

            }
            return dibujo.Length > 0;

        }



    }
}
