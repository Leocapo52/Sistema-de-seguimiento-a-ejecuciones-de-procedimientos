using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Clases
{
    /// <summary>
    /// class enum to define the state of the procedures
    /// </summary>
    public enum State
    {  
        iddle,
        Running,
        Paused,
        Completed

    }
}
