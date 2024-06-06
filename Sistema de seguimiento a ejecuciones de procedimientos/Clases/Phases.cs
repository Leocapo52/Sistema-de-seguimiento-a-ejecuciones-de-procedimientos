using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_seguimiento_a_ejecuciones_de_procedimientos.Clases
{
    public class Phases
    {
        public string ID { get; }
        public string Name { get; }
        public string Description { get;}
        public Phases (string ID, string Name, string Description)
        {
            this.ID = ID;
            this.Name = Name;
            this.Description = Description;
        }
    }
}
