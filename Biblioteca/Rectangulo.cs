using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        public Rectangulo(Punto vertice1 ,Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.area = this.GetArea();
            this.perimetro = this.GetPerimetro();
        }

        public float GetArea()
        {
            float altura = (float)this.vertice2.GetY() - (float)this.vertice1.GetY();
            float baseA = (float)this.vertice4.GetX() - (float)this.vertice1.GetX();

            this.area = (baseA * altura);
            return this.area;
        }

    
        public float GetPerimetro()
        {
            float altura = (float)this.vertice2.GetY() - (float)this.vertice1.GetY();
            float baseA = (float)this.vertice4.GetX() - (float)this.vertice1.GetX();
            this.perimetro = (2 * baseA) + (2 * altura);
            return this.perimetro;
        }
    }
}
