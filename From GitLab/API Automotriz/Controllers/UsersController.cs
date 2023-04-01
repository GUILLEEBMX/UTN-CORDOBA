
using API_Automotriz.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.Domain;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace API_Automotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices userServices;

        public UsersController(IUserServices userServices)
        {

            this.userServices = userServices;

        }

        //GET: api/users
        /// <summary>
        /// Obtiene un listado de usuarios
        /// </summary>
        /// Las propiedades de los usuarios estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/users")]
        public ActionResult<List<User_>> GetProducts()
        {

            return userServices.GetAllUsers();

        }


        //POST: api/users
        /// <summary>
        /// Loggea al usuario en la Aplicacion
        /// </summary>
        /// Las propiedades del usuario estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpPost("/users/loggin")]
        public ActionResult<UserLogginDTO> LogginUser(UserLogginDTO user)
        {

            return userServices.LogginUser(user);

        }

        //POST: api/users
        /// <summary>
        /// Registra un nuevo usuario en la Aplicacion
        /// </summary>
        /// Las propiedades del usuario estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpPost("/users/register")]
        [ApiExplorerSettings(IgnoreApi = false)]
        public ActionResult<UserRegisterDTO> RegisterUser(UserRegisterDTO user)
        {

            return userServices.CreateUser(user);

        }

        //POST: api/users
        /// <summary>
        /// Registra un nuevo administrador en la Aplicacion
        /// </summary>
        /// Las propiedades del usuario estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpPost("/users/admin/register")]
        public ActionResult CreateAdmin(UserAdminDTO user)
        {

            return userServices.CreateAdmin(user);

        }

        //DELETE: api/users
        /// <summary>
        /// Elimina un usuario del rol de Administrador
        /// </summary>
        /// Las propiedades del usuario estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpDelete("/users/admin/delete")]
        [ApiExplorerSettings(IgnoreApi = false)]
        public ActionResult DeleteAdmin(string email)
        {

            return userServices.DeleteAdmin(email);


        }


        //DELETE: api/users
        /// <summary>
        /// Elimina al usuario de la Base de Datos
        /// </summary>
        /// Las propiedades del usuario estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpDelete("/users/delete")]
        public ActionResult DeleteUser(string email)
        {

            return userServices.DeleteUser(email);


        }

    }

}
