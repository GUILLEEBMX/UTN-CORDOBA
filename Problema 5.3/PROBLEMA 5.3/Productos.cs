using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROBLEMA_5._3
{
    class Productos
    {

        public int Codigo { get; set; }
        public string Detalle { get; set; }
        public int Tipo { get; set; }
        public int Marca { get; set; }
        public double Precio { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString()
        {
            return "Codigo:" + Codigo + "\nDetalle" + Detalle + "\nTipo" + Tipo + "\nMarca" + Marca
                 + "\nPrecio" + Precio + "\nFecha" + Fecha;
        }










    }
}
