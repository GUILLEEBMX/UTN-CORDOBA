using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary
{
    public class OrderDetail
    {
        public int IdDetallePedido { get; set; }
        public int IdProducto { get; set; }

        public int IdPedido { get; set; }

        public int Cantidad { get; set; }

        public double PrecioCompra { get; set; }
    }
}
