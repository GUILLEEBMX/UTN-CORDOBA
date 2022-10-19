using API_Problema_4._4.Models;
using API_Problema_4._4.Services.ProductServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Problema_4._4.Controllers
{
    [ApiController]
    [Route("api/V1/products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productServices;
        public ProductsController(IProductService _productServices)
        {
            productServices =_productServices;

        }

        //GET: api/products
        /// <summary>
        /// Obtiene un listado de personas
        /// </summary>
        /// Las propiedades de las personas estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet(Name = "ObtenerProductosV1")]
       // [AllowAnonymous]
       // [ServiceFilter(typeof(HATEOASPersonasDTOFilterAttribute))]

        public  ActionResult<List<ProductModel>> Get()
        {
            return productServices.Get();

        }

        /// <summary>
        /// Obtiene un producto por su ID.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="id">Id de producto.</param>

        [HttpGet("{id}", Name = "ObtenerPersonaXIdV2")]
       // [AllowAnonymous]
        //[ServiceFilter(typeof(HATEOASPersonasDTOFilterAttribute))]
        public ActionResult GetxID(int id)
        {
            return productServices.GetxID(id);
        }

        /// <summary>
        /// Crea un producto en la BD.
        /// </summary>
        /// <remarks>
        /// Crea una producto en la BD.
        /// </remarks>

        [HttpPost(Name = "CrearArticuloV2")]
        public ActionResult<ProductModel> Post(ProductModel product)
        {

            return productServices.Post(product);
        }


        /// <summary>
        /// Actualiza un producto de la BD.
        /// </summary>
        /// <remarks>
        /// Actualiza el producto segun ID
        /// </remarks>
        /// <param name="id">Id de persona.</param>


        [HttpPut("{id}", Name = "ActualizarProductoV1")]
        public ActionResult Put(int id, ProductModel product)
        {

            return productServices.Put(id, product);

        }

        /// <summary>
        /// Borra un producto de la BD.
        /// </summary>
        /// <remarks>
        /// Borra un producto según el ID indicado.
        /// </remarks>

        [HttpDelete("{id}", Name = "BorrarProductoV1")]
        public  ActionResult Delete(int id)
        {
            return productServices.Delete(id);
        }

    }
}
