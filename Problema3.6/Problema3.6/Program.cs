using System;

namespace Problema3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio bussiness = new Negocio(3);
           

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("INGRESA LA MARCA...");
            //    var marca = Console.ReadLine();
            //    Console.WriteLine("INGRESA EL CODIGO DE LA MARCA...");
            //    var codigo = int.Parse(Console.ReadLine());
            //    Console.WriteLine("INGRESA EL PRECIO DE LA MARCA...");
            //    var precio = double.Parse(Console.ReadLine());
            //    Console.WriteLine("INGRESA EL TIPO DE PRODUCTO...");
            //    var tipo = Console.ReadLine();
            //    Producto product = new Producto(marca,codigo,precio,tipo);
            //    bussiness.AñadirProductos(i, product);

            //}

            for (int i = 0; i < 3; i++)
            {

                Random r = new Random();

                //Producto product = new Producto("Honda", 1, r.Next(1,1000), "pack");
                Pack pack = new Pack();
                Suelto suelto = new Suelto();
                bussiness.AñadirProductos(i,suelto);
                bussiness.AñadirProductos(i, pack);

            }



            //Console.WriteLine("EL PRODUCTO MÁS CARO ES DE LA MARCA Y CODIGO: ");
            //Console.WriteLine(bussiness.MarcaPackMasCostoso().Marca + " " + bussiness.MarcaPackMasCostoso().Codigo);

            Console.WriteLine("EL PRECIO TOTAL ES: ");
            Console.WriteLine(bussiness.PrecioTotal());

     



        }


    }
}
