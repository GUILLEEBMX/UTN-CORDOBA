using API_Automotriz.Services;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubsidiariesController : ControllerBase
    {
        private ISubsidiaryServices subsidiaryServices;
        public SubsidiariesController(ISubsidiaryServices subsidiaryServices)
        {
            this.subsidiaryServices = subsidiaryServices;

        }


        //GET: api/subsidiaries
        /// <summary>
        /// Obtiene un listado de productos
        /// </summary>
        /// Las propiedades de los productos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/subsidiaries")]
        public ActionResult<List<Subsidiary>> GetAllSubsidiaries()
        {

            return subsidiaryServices.GetAllSubsidiaries();

        }
    }
}
