﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;


        public Sumador()
        {
            this.cantidadSumas = 0;
        }

        public Sumador(int cant)
        {
            this.cantidadSumas = cant;
        }
        public static bool operator |(Sumador s1, Sumador s2){
            return s1.cantidadSumas == s2.cantidadSumas;
        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }

        public long Sumar(long a , long b)
        {
            this.cantidadSumas++;

            return a + b;
        }


        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b;
        }


        public static explicit operator int (Sumador s)
        {
            return s.cantidadSumas;
        }


    }
}
