using API_Automotriz.Services;
using AutomotrizLibrary.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace API_Automotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployServices employServices;
        public EmployeesController(IEmployServices employServices)
        {
            this.employServices = employServices;

        }

        //GET: api/employees
        /// <summary>
        /// Obtiene un listado de usuarios
        /// </summary>
        /// Las propiedades de los usuarios estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/employees")]
        public ActionResult<List<Employ>> GetProducts()
        {

            return employServices.GetAllEmployees();

        }

    }
}
