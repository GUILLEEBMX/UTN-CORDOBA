using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Programacion_II
{
    class Parameter
    {

        public Parameter(string name, object value)
        {
            Name = name;
            Value = value;

        }

        public string Name { get; set; }
        public object Value { get; set; }

    }
}
