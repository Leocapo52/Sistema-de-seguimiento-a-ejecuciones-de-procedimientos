using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Clases
{
    public class Date
    {
        /// <summary>
        /// time defined in format "0000" to "2359"
        /// </summary>
        public int Time { get; set; }
        /// <summary>
        /// date defined in format yearmonthday example 010216 to 2001 february 16
        /// </summary>
        public int date { get; set; }

    }
}
