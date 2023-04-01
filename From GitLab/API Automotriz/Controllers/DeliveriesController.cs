using API_Automotriz.Services;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Controllers
{

    [Route("api/[controller]")]
    [ApiController]


    public class DeliveriesController : ControllerBase
    {
        private readonly IDeliverieServices deliverieServices;
        public DeliveriesController(IDeliverieServices deliverieServices)
        {
            this.deliverieServices = deliverieServices;

        }


        //GET: api/deliveries
        /// <summary>
        /// Obtiene un listado de usuarios
        /// </summary>
        /// Las propiedades de los usuarios estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/deliveries")]
        public ActionResult<List<Delivery>> GetAllDeliveries()
        {

            return deliverieServices.GetAllDeliveries();

        }


    }
}
