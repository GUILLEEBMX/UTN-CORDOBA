using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._6
{
    class Suelto : Producto
    {
        public Suelto() :base ()
        {

        }
        public int Medida { get; set; }

        public override double GetPrecio()
        {
            PrecioUnitario = 1;
            Medida = 2;


            return PrecioUnitario * Medida;
        }




    }
}
