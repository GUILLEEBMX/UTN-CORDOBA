using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._6
{
    class Pack : Producto
    {
        public Pack() : base ()
        {

        }

        public int Cantidad { get; set; }

        public override double GetPrecio()
        {
            Random r = new Random();

            PrecioUnitario = 1;
            Cantidad = 1;

            return PrecioUnitario * Cantidad;
        }








    }
}
