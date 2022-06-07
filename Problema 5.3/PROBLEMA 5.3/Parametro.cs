using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_5._3
{
    class Parametro
    {


        public Parametro(string nombre, object valor )
        {
            this.Nombre = nombre;
            this.Valor = valor;
                
        }

        public string Nombre { get; set; }

        public object Valor  {get;set;}


    }
}
