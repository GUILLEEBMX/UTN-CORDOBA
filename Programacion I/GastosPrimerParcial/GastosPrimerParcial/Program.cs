using System;

namespace GastosPrimerParcial
{
    class Program
    {
        static void Main(string[] args)
        {

            Municipio muni = new Municipio();
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                Gasto gasto = new Gasto(r.Next(1, 1000));
                muni.RegistrarGasto(i, gasto);
            }


            Console.WriteLine("EL GASTO MAYOR ES: " + muni.MostrarMayorGasto());


        }
    }
}
