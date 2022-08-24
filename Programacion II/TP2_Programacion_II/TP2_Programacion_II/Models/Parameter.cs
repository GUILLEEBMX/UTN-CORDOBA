using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Programacion_II
{
    public class Parameter
    {

        public Parameter(string name, object value)
        {
            this.Name = name;
            this.Value = value;

        }
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
