using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Clases
{
    public class UnitProcedure : Operations
    {
        public Queue<Operations> Operations { get; set; }
        public Date StartTime { get; set; }
        public Date EndTime { get; set; }
        public State state { get; set; }
        public UnitProcedure(string ID, string Name, string Description, string Code) : base(ID, Name, Description, Code)
        { 
            StartTime = new Date();
            EndTime = new Date();
            Operations = new Queue<Operations>();

        }

    }
}
