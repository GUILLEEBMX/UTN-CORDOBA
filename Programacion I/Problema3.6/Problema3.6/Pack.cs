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

        public Pack(string marca,int codigo,double precioUnitario,string tipo, int cantidad) 
                   :base(marca,codigo,precioUnitario,tipo)
        {
            this.Cantidad = cantidad;
        }

        public int Cantidad { get; set; }

        public override double GetPrecio()
        {
            return PrecioUnitario * Cantidad;
        }








    }
}
