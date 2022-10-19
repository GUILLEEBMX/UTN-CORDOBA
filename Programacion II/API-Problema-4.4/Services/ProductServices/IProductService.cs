using API_Problema_4._4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Problema_4._4.Services.ProductServices
{
    public interface IProductService
    {
        public ActionResult<List<ProductModel>> Get();
        public ActionResult GetxID(int id);
        public ActionResult Post(ProductModel product);
        public ActionResult Put(int id, ProductModel product);
        public ActionResult Delete(int id);
    }
}
