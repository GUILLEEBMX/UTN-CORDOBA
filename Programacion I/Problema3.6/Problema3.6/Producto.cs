using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._6
{
    class Producto
    {
        public Producto()
        {

        }

        public Producto(string marca, int codigo,double precioUnitario,string tipo)
        {
            this.Marca = marca;
            this.Codigo = codigo;
            this.PrecioUnitario = precioUnitario;
            this.Tipo = tipo;
            

        }

        public int Codigo { get; set; }

        public string Marca { get; set; }

        public double PrecioUnitario { get; set; }

        public string Tipo { get; set; }

        public virtual double GetPrecio()
        {
            return 0;
        }

    


       










    }
}
