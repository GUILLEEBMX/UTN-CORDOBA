using API_Automotriz.Services;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API_Automotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RequestTypesController : ControllerBase
    {
        private readonly IRequestTypeServices requestTypeServices;
        public RequestTypesController(IRequestTypeServices requestTypeServices)
        {
            this.requestTypeServices = requestTypeServices;

        }



        //GET: api/requestTypes
        /// <summary>
        /// Obtiene un listado de usuarios
        /// </summary>
        /// Las propiedades de los usuarios estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/requestType")]
        public ActionResult<List<RequestType>> GetAllReqyestTypes()
        {

            return requestTypeServices.GetAllRequestTypes();

        }

    }
}
