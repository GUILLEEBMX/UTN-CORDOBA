using API_Automotriz.Services;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientServices clientServices;
        public ClientsController(IClientServices clientServices)
        {
            this.clientServices = clientServices;
        }


        //GET: api/clients
        /// <summary>
        /// Obtiene un listado de usuarios
        /// </summary>
        /// Las propiedades de los usuarios estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/clients")]
        public ActionResult<List<Client>> GetAllClients()
        {

            return clientServices.GetAllClients();

        }

    }
}
