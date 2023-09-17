using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6
{
    internal class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        public AutoF1(short numero,string escuderia)
        {
            this.enCompetencia = false;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.numero = numero;
            this.escuderia = escuderia;

        }


        public string MostrarDatos() {

            StringBuilder sb = new();

            sb.Append($"\nen competencia : {this.enCompetencia} ");
            sb.Append($"\nen cantidadCombustible : {this.cantidadCombustible} ");
            sb.Append($"\nen vueltasRestantes : {this.vueltasRestantes} ");
            sb.Append($"\nen numero : {this.numero} ");
            sb.Append($"\nen escuderia : {this.escuderia} ");
            return sb.ToString();
           
        
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return a1.numero == a2.numero && a1.escuderia == a2.escuderia;
        }
        public static bool operator !=(AutoF1 a1 ,AutoF1 a2)
        {
            return !(a1 == a2);
        }

        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }
        public bool GetEnCompentencia()
        {
            return this.enCompetencia;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible=cantidadCombustible;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public void SetEnVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }
    }
}
