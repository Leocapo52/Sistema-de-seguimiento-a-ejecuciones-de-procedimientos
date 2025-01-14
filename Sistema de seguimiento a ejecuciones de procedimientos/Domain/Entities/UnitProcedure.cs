﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Type;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Domain.Entities
{
    public class UnitProcedure : Base
    {
        #region Properties
        /// <summary>
        /// Cola para las operaciones
        /// </summary>
        public Queue<Operations> Operations { get; set; }
        /// <summary>
        /// Codigo de la unidad a la que pertenece
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Fecha y hora de inicio 
        /// </summary>
        public string? UnitCode { get; set; }

        #endregion

        #region Constructors
        public UnitProcedure(string ID, string Name, string Code) : base (ID, Name)
        {
            this.Code = Code;
            Operations = new Queue<Operations>();
       

        }
        #endregion

    }
}
