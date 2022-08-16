using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Parametro
    {
       
        public Parametro(string name, object values)
        {
            this.Name = name; 
            this.Value = values;
        }

        public string Name { get; set ; }

        public object Value { get; set; }



    }
}
