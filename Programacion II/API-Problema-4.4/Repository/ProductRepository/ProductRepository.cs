using API_Problema_4._4.Models;
using API_Problema_4._4.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Problema_4._4.Repository.ProductRepository
{
    public class ProductRepository : IProductService
    {
        
        public ProductRepository()
        {
           
        }


        public  ActionResult<List<ProductModel>> Get()
        {

            return ProductModel.Products;

        }

        public ActionResult GetxID(int id)
        {
            var existe = false;
            int index = 0;

            if( ProductModel.Products == null)
            {
                return new NotFoundObjectResult("ESE ARTICULO NO EXISTE EN NUESTRA BASE DE DATOS...");
            }

            for (int i = 0; i < ProductModel.Products.Count; i++)
            {
                if (ProductModel.Products[i].Codigo == id)
                {
                    existe = true;
                    index = i;

                }

            }

            

            if (!existe )
            {
                return new NotFoundObjectResult("ESE ARTICULO NO EXISTE EN NUESTRA BASE DE DATOS...");
            }

            return new OkObjectResult(ProductModel.Products[index]);
        }

        public ActionResult Post(ProductModel product)
        {


             ProductModel.Products.Add(product);

            return new CreatedAtRouteResult("ObtenerProductoXIdV1", new { id = product.Codigo });
        }

        public ActionResult Put(int id, ProductModel product)
        {
            if (product.Codigo != id)
            {
                return new BadRequestObjectResult("LOS IDs INGRESADOS DE LAS PERSONAS NO COINCIDEN");
            }

            if (ProductModel.Products == null)
            {
                return new NotFoundObjectResult("ESE ARTICULO NO EXISTE EN NUESTRA BASE DE DATOS...");
            }

            var existe = false;
         


            for (int i = 0; i < ProductModel.Products.Count; i++)
            {
                if (ProductModel.Products[i].Codigo == id)
                {
                    existe = true;
                    

                }

            }



            if (!existe)
            {
                return new NotFoundObjectResult("ESE ARTICULO NO EXISTE EN NUESTRA BASE DE DATOS...");
            }


            ProductModel.Products.Add(product);

            
            return new CreatedAtRouteResult("ObtenerProductoXIdV1", new { id = product.Codigo }, product);

        }

        public ActionResult Delete(int id)
        {
            var existe = false;
            


            for (int i = 0; i < ProductModel.Products.Count; i++)
            {
                if (ProductModel.Products[i].Codigo == id)
                {
                    existe = true;
                    
                }

            }

            if (!existe)
            {
                return new NotFoundObjectResult("ESE PRODUCTO NO EXISTE EN NUESTRA BASE DE DATOS");

            }
            else
            {
                ProductModel.Products.RemoveAt(5);


            }

            return new OkObjectResult("EL PRODUCTO CUYO ID ERA: " + id + " HA SIDO BORRADA DE MANERA CORRECTA ");
        }


    }
}
