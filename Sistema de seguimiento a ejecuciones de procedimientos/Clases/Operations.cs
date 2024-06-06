using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Clases
{
    public class Operations : Phases
    {
       public Queue<Phases> phases {  get; set; }
       public string Code { get; }
       public Operations (string ID, string Name, string Description, string Code) : base(ID, Name, Description)
        {
            this.Code = Code;
            phases = new Queue<Phases> (); 
        }



    }
}
