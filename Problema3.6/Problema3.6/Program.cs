using System;

namespace Problema3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio bussiness = new Negocio(3);

            Pack pack = new Pack("PACK", 1, 1997, "PACK", 5);
            Suelto suelto = new Suelto("SUELTO", 2, 1996, "SUELTO", 2);

            bussiness.AñadirProductos(0,pack);
            bussiness.AñadirProductos(1,suelto);
            bussiness.AñadirProductos(2,pack);

            Console.WriteLine("EL PRODUCTO MÁS CARO ES DE LA MARCA Y CODIGO: ");
            Console.WriteLine(bussiness.MarcaPackMasCostoso().Marca + " " + bussiness.MarcaPackMasCostoso().Codigo);
         
            Console.WriteLine("EL PRECIO TOTAL ES: ");
            Console.WriteLine(bussiness.PrecioTotal());

     



        }


    }
}
