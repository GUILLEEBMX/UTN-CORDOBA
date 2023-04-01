using API_Automotriz.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices orderService;
        public OrderController(IOrderServices orderService)
        {
            this.orderService = orderService;

        }



        //GET: api/order
        /// <summary>
        /// Obtiene un listado de pedidos
        /// </summary>
        /// Las propiedades de los pedidos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/orders")]
        public ActionResult<List<Order>> GetAllOrders()
        {

            return orderService.GetAllOrders();

        }

        //GET: api/order
        /// <summary>
        /// Obtiene un Pedido
        /// </summary>
        /// Las propiedades de los productos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("{id:int}", Name = "OrderId")]
        public ActionResult<Order> GetAllOrders(int id)
        {

            return orderService.GetID(id);

        }


        //POST: api/order
        /// <summary>
        /// Graba un pedido nuevo en la BD 
        /// </summary>
        /// Las propiedades de los pedidos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpPost("/registerOrder")]
        public ActionResult PostOrder(OrderPostDTO order)
        {
            return orderService.PostOrder(order);
        }




    }
}
