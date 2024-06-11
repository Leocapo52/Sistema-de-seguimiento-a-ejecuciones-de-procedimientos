using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Type;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Entities
{
    public class Phases : Base
    {


        #region Constructors
        public Phases(string IC, string Name, string Description = "N/A") : base (IC,Name,Description)
        {

        }
        #endregion


    }
}
