using API_Automotriz.Services;
using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_Automotriz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {

        private readonly IProductServices productServices;

        public ProductsController(IProductServices _productServices)
        {
            productServices = _productServices;

        }



        //GET: api/products
        /// <summary>
        /// Obtiene un listado de productos
        /// </summary>
        /// Las propiedades de los productos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("/products")]
        public ActionResult<List<ProductDTO>> GetAllProducts()
        {

            return productServices.GetAllProducts();

        }

        //GET: api/products
        /// <summary>
        /// Obtiene un listado de productos
        /// </summary>
        /// Las propiedades de los productos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpGet("{id:int}",Name = "productsID")]
        public ActionResult<ProductDTO> GetAllProducts(int id)
        {

            return productServices.GetID(id);

        }


        //POST: api/products
        /// <summary>
        /// Graba un producto nuevo en la BD 
        /// </summary>
        /// Las propiedades de los productos estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpPost ("/registerProduct")]
        public ActionResult PostProduct(ProductPostDTO product)
        {
            return productServices.PostProduct(product);
        }



        //DELETE: api/products
        /// <summary>
        /// Elimina un producto de la Base de Datos
        /// </summary>
        /// Las propiedades del producto estan acotadas a las requeridas por el modelo
        /// <returns></returns>

        [HttpDelete("/delete")]
        public ActionResult DeleteProduct(int id)
        {

            return productServices.DeleteProduct(id);


        }




    }
}
