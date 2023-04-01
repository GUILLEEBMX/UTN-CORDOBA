using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary.DTOs
{
    public  class OrderPostDTO
    {
        public OrderPostDTO()
        {
            OrderDetails = new List<OrderDetailDTO>();
        }
        public int IdProveedor { get; set; }
        public int IdSucursal { get; set; }
        public int IdEntrega { get; set; }
        public int IdTipoSolicitud { get; set; }
        public int IdEmpleadoReceptor { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime HoraPedido { get; set; }
        public DateTime FechaEntregaPedido { get; set; }

        public DateTime PlazoEntregaPedido { get; set; }
        public int Cliente { get; set; }

        public List<OrderDetailDTO> OrderDetails { get; set; }
    }
}
