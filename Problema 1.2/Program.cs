using System;

namespace Problema_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Silo silo = new Silo();


            Console.WriteLine("INGRESA EL VALOR DEL RADIO...");

            silo.Radio = double.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA EL VALOR DE LA ALTURA...");

            silo.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("EL VOLUMEN DEL SILO SERA DE: " + silo.CalcularVolumen());
        }
    }
}
