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
            if (index > productos.Length)
            {
                throw new ArgumentException("ERROR");
            }

            if (productos[index] == null)
            {
                productos[index] = producto;
            }

        
        }

        public int CantidadProductosSueltos()
        {
            
            int cantidadProductosSueltos = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] is Suelto )
                {
                    cantidadProductosSueltos++;
                }
            }

            return cantidadProductosSueltos;
        }

      
        public int CantidadProductosPack()
        {
            int cantidadProductosPack = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] is Pack)
                {
                    cantidadProductosPack++;
                }
            }

            return cantidadProductosPack;
        }

        public double PorcentajePack()
        {
           return CantidadProductosPack() * 100 / cantidadProductos;
        }

        public Producto MarcaPackMasCostoso()
        {
            var masCostoso = productos[0];
            
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Tipo == "PACK" && productos[i].PrecioUnitario > masCostoso.PrecioUnitario)
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
