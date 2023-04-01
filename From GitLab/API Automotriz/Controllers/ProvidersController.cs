using API_Automotriz.Services;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Controllers
{
     [Route("api/[controller]")]
     [ApiController]
    public class ProvidersController : ControllerBase 
    {
        private readonly IProviderServices providerServices;

        public ProvidersController(IProviderServices providerServices)
        {
            this.providerServices = providerServices;

        }



        //GET: api/providers
        /// <summary>
        /// Obtiene un listado de productos
        /// </summary>
        /// Las propiedades de los productos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/providers")]
        public ActionResult<List<Provider>> GetAllProviders()
        {

            return providerServices.GetAllProviders();

        }


    }
}
