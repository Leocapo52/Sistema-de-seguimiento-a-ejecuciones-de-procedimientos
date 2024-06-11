using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Type;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Entities
{
    public class Operations : Base
    {
        #region Properties
        /// <summary>
        /// secuencia de fases para una operacion
        /// </summary>
        public Queue<Phases> phases { get; set; }
        /// <summary>
        /// codigo de la operacion
        /// </summary>
        public string Code { get; set; }
        #endregion



        #region Constructor
        public Operations(string ID, string Name, string Code, string Description = "N/A") : base(ID, Name, Description)
        {
            this.Code = Code;
            phases = new Queue<Phases>();
        }
        #endregion



    }
}
