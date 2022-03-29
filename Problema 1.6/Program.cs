using System;

namespace Problema_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil();


            Console.WriteLine("INGRESE LA CANTIDAD DE KM A RECORRER...");
            auto.CantidadKM = double.Parse(Console.ReadLine());


            Console.WriteLine("INGRESE LA CANTIDAD DE LITROS...");
            auto.NivelActualLitros = double.Parse(Console.ReadLine());

            Console.WriteLine(auto.Conducir());
            



            Console.WriteLine("INGRESE LA CANTIDAD DE LITROS A CARGAR...");
            auto.LitrosCargar = double.Parse(Console.ReadLine());

            Console.WriteLine(auto.Cargar());



        }
    }
}
