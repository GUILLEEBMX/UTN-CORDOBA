using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Problema_4._4.Models
{
    public class ProductModel
    {
        public ProductModel()
        {
            Products = new List<ProductModel>();
        }
        public int Codigo { get; set; }

        public string Nombre { get; set; }

        public int Precio { get; set; }

        public static List<ProductModel> Products { get; set; }
    }
}
