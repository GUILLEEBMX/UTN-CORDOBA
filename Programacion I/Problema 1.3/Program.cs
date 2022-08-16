using System;

namespace Problema_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto();


            Console.WriteLine("LA DISTANCIA ENTRE AMBOS PUNTOS ES: " + punto1.CalcularDistancia());

            Console.WriteLine("LA COORDENADA ES: " + punto1.CoordenadaX + ";" + punto1.CoordenadaY);
        }
    }
}
