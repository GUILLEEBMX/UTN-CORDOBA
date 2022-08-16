using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Programacion_II
{
    class Factura
    {
        public DateTime Fecha { get; set; }
        public int FormaPago { get; set; }
        public string Cliente { get; set; }
        public  DetalleFactura DetalleFactura { get; set; }
    }
}
