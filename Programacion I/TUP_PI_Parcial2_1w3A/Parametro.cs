using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUP_PI_Parcial2_13A
{
    class Parametro
    {
        public Parametro(string nombre, object valor)
        {
            this.Nombre = nombre;
            this.Valor = valor;

        }

        public string Nombre { get; set; }

        public object Valor { get; set; }


    }
}

