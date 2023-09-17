using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    internal class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;


        private Competencia()
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas,short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new();

            sb.Append($"\n cantidad Competidores: {cantidadCompetidores}");
            sb.Append($"\n cantidadVueltas: {cantidadVueltas}");
            foreach(AutoF1 competido in competidores)
            {
                sb.Append($"\n" + competido.MostrarDatos());
            }

            return sb.ToString();
        }


        public static bool operator -(Competencia c, AutoF1 a1)
        {
            if (c.competidores.Count > 0)
            {
                c.competidores.Remove(a1);
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool operator +(Competencia c, AutoF1 a1)
        {
           
            if(c.competidores.Count < c.cantidadCompetidores )
            {
                bool res = false;
                if (c.competidores.Count > 0)
                {
                    bool competidorYaEnLista = false;

                    for (int i = 0; i < c.competidores.Count; i++)
                    {
                        if (c.competidores[i] == a1)
                        {
                            competidorYaEnLista = true;
                            break; // No es necesario continuar el bucle si ya encontramos el competidor.
                        }
                    }

                    if (!competidorYaEnLista)
                    {
                        c.competidores.Add(a1);
                        a1.SetEnCompetencia(true);
                        a1.SetEnVueltasRestantes(c.cantidadVueltas);
                        a1.SetCantidadCombustible((short)new Random().Next(15, 100));
                        return true;
                    }
                }
                else
                {
                    c.competidores.Add(a1);
                    a1.SetEnCompetencia(true);
                    a1.SetEnVueltasRestantes(c.cantidadVueltas);
                    a1.SetCantidadCombustible((short)new Random().Next(15, 100));
                    res = true;
                }
                
                return res;
            }
            else
            {
                return false;
            }
        }


        public static bool operator ==(Competencia c, AutoF1 a1)
        {
            return c.competidores.Contains(a1);
        }
        public static bool operator !=(Competencia c, AutoF1 a1)
        {
            return !(c.competidores.Contains(a1));
        }
    }
}
