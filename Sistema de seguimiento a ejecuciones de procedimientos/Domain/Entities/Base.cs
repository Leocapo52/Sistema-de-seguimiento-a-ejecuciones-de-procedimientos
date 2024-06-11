using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Utilities;
using Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Type;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Entities
{
    public abstract class Base
    {
        #region Properties

        /// <summary>
        /// codigo identificador
        /// </summary>
        public string IdentificationCode { get; set; }
        /// <summary>
        /// nombre de las operaciones
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// descripcion de las operaciones
        /// </summary>
        public string Description { get; set; }
        #endregion

        #region Constructors
        public Base (string IC, string Name, string Description = "N/A")
        {
            this.IdentificationCode = IC;
            this.Name = Name;
            this.Description = Description;
        }
        #endregion
    }
}
