using AutomotrizLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary
{
    public class Order
    {
        public Order()
        {
            OrderDetails = new List<OrderDetailDTO>();
        }
        public int IdPedido { get; set; }
        public int IdProveedor { get; set; }
        public int IdSucursal { get; set; }
        public int IdEntrega { get; set; }
        public int IdTipoSolicitud { get; set; }
        public int IdEmpleadoReceptor { get; set; }
        public DateTime FechaPedido { get; set; }
        public string HoraPedido { get; set; }
        public DateTime FechaEntregaPedido { get; set; }

        public string PlazoEntregaPedido { get; set; }
        public int Cliente { get; set; }

        public List<OrderDetailDTO> OrderDetails { get; set; }






      





        






    }
}
