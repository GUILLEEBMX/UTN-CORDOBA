using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema3._6
{
    class Negocio
    {
        private Producto[] productos;
        private int cantidadProductos;
   
        public Negocio(int cantidadProductos)
        {
            this.cantidadProductos = cantidadProductos;
            productos = new Producto[cantidadProductos];
           
        }
        public int CantidadProductos { get; set; }

        public void AñadirProductos(int index, Producto producto )
        {
            if (index > cantidadProductos)
            {
                throw new ArgumentException("ERROR");
            }
            productos[index] = producto;
        }

        public int CantidadProductosTipoSueltos(Suelto suelto)
        {
            int cantidadProductosSueltos = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] == suelto)
                {
                    cantidadProductosSueltos++;
                }
            }

            return cantidadProductosSueltos;
        }

        public int CantidadProductosSueltos(Suelto suelto)
        {
            int cantidadProductosSueltos = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] == suelto)
                {
                    cantidadProductosSueltos++;
                }
            }

            return cantidadProductosSueltos;
        }

        public int CantidadProductosPack(Pack pack)
        {
            int cantidadProductosPack = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] == pack)
                {
                    cantidadProductosPack++;
                }
            }

            return cantidadProductosPack;
        }

        //public double PorcentajePack()
        //{
        //    var cantidadProductosPack = CantidadProductosPack(Pack pack)


        //   return  CantidadProductosPack(Pack pack) * 100 / CantidadProductos;
        //}

        public Producto MarcaPackMasCostoso()
        {
            var masCostoso = productos[0];
            
            for (int i = 0; i < CantidadProductos; i++)
            {
                if (productos[i].Tipo == "pack" && productos[i].PrecioUnitario > masCostoso.PrecioUnitario)
                {
                    masCostoso = productos[i];
                }
            }

             return masCostoso;
        }

        public double PrecioTotal()
        {
            double precioTotal = 0;
            foreach (Producto x in productos)
            {
                if (x != null)
                {
                    precioTotal += x.GetPrecio();
                }
                    
            }

            return precioTotal;
        }

        public Producto [] MostrarProductos ()
        {
            return productos;
        }

    

      
        






    }
}
