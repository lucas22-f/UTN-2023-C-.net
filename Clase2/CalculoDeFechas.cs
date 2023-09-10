using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase2
{
    internal class CalculoDeFechas
    {
        public static int DiferenciaDeFechas(DateTime fecha)
        {
            TimeSpan res = DateTime.Now.Subtract(fecha);
            int diasVividosExtra = 0;
            for (int año = fecha.Year; año < DateTime.Now.Year; año++)
            {
                if (DateTime.IsLeapYear(año))
                {
                    diasVividosExtra++;
                }
            }
            return res.Days + diasVividosExtra;
        }

    }
}
