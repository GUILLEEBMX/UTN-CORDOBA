using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary.DTOs
{
    public  class OrderDetailDTO
    {
        public int IdProducto { get; set; }


        public int Cantidad { get; set; }

        public double PrecioCompra { get; set; }

        
    }
}
