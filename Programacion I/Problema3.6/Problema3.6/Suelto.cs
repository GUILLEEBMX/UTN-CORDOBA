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

        public Suelto (string marca, int codigo, double precioUnitario, string tipo, int medida)
                      : base(marca, codigo, precioUnitario, tipo)
        {
            this.Medida = medida;
        }

        public int Medida { get; set; }

        public override double GetPrecio()
        {
     
            return PrecioUnitario * Medida;
        }




    }
}
