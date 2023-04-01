﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomotrizLibrary
{
    public class Products
    {
        public int IdProducto { get; set; }
        public int IdMarca { get; set; }
        public int IdRubro{ get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }


    }
}