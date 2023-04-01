using AutomotrizLibrary;
using AutomotrizLibrary.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace API_Automotriz.Services
{
    public interface IProductServices
    {
        public ActionResult<List<ProductDTO>> GetAllProducts();
        public ActionResult<ProductDTO> GetID(int id);
        public ActionResult PostProduct(ProductPostDTO product);

        public ActionResult DeleteProduct(int id);

    }
}
