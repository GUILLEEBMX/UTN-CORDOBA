using System;

namespace Problema3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INGRESA LA CANTIDAD DE PRODUCTOS...");
            int cantidadProductos = int.Parse(Console.ReadLine());
            Negocio bussiness = new Negocio(cantidadProductos);

            Random random = new Random();

            for (int i = 0; i < cantidadProductos; i++)
            {
                Pack pack = new Pack("HONDA", random.Next(1, 30), random.Next(1,954), "PACK", random.Next(1, 100));
                Suelto suelto = new Suelto("MAZDA", random.Next(1, 30), random.Next(1, 500), "SUELTO", random.Next(1, 800));
                if (i % 2 == 0)
                {
                    
                    bussiness.AñadirProductos(i, pack);
                }
                else
                {
                    
                    bussiness.AñadirProductos(i, suelto);
                }



            }

        
            Console.WriteLine("\nEL PRODUCTO MÁS CARO ES: ");
            Console.WriteLine("MARCA:" + bussiness.MarcaPackMasCostoso().Marca + " || "  + "CODIGO:" + bussiness.MarcaPackMasCostoso().Codigo);
         
            Console.WriteLine("\nLA CANTIDAD DE PRODUCTOS DE TIPO SUELTO SON: ");
            Console.WriteLine(bussiness.CantidadProductosSueltos());
     

            Console.WriteLine("\nLA CANTIDAD DE PRODUCTOS DE TIPO PACK SON: ");
            Console.WriteLine(bussiness.CantidadProductosPack());

            Console.WriteLine("\nEL PORCENTAJE DE PRODUCTOS TIPO PACK ES EL: " + bussiness.PorcentajePack() +  "%");

            Console.WriteLine("\nTODOS LOS PRODUCTOS INGRESADOS SON:\n");
           
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine(
               "CODIGO: " + bussiness.MostrarProductos()[i].Codigo
               +
               " || MARCA: " + bussiness.MostrarProductos()[i].Marca
               +
               " || TIPO: " + bussiness.MostrarProductos()[i].Tipo
               +

               " || PRECIO UNITARIO: $" + bussiness.MostrarProductos()[i].PrecioUnitario
                
                );

            }

            Console.WriteLine("\nEL PRECIO TOTAL DE TODOS LOS PRODUCTOS ES: ");
            Console.WriteLine("$ " + bussiness.PrecioTotal());




        }


    }
}
