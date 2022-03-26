using System;

namespace Problema_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine("INGRESA TU EDAD...");
            persona.Edad = int.Parse(Console.ReadLine());


            Console.WriteLine("INGRESA TU PESO...");
            persona.Peso = double.Parse(Console.ReadLine());

            Console.WriteLine("INGRESA TU ALTURA...");
            persona.Altura = double.Parse(Console.ReadLine());


            Console.WriteLine("EL IMC TUYO ES: " + persona.CalcularIMC());
            Console.WriteLine("ERES MAYOR DE EDAD: " + persona.EsMayor());

            
        }
    }
}
