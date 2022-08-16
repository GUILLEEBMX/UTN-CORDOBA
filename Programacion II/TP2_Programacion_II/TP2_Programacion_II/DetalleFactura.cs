using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Programacion_II
{
    class DetalleFactura
    {
        public int IdArticulo { get; set; } //OBJETO ARTICULO COMO TAL
        public int IdFactura { get; set; }

        public Articulo Articulo {get;set; }
        public int Cantidad { get; set; }




    }
}
