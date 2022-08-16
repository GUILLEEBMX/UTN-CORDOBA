using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_Recuperatorio_1W3
{
    class Parametro
    {

        public Parametro(string name, object values)
        {
            this.Name = name;
            this.Values = values;

        }

        public string Name { get; set; }
        public object Values { get; set; }

      

    }
}
