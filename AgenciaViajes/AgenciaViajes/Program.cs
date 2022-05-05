using System;

namespace AgenciaViajes
{
    class Program
    {
        static void Main(string[] args)
        {
            Agencia agencia = new Agencia(5);

            Crucero cruise = new Crucero();


       

            for (int i = 0; i < 5; i++)
            {
                agencia.RegistrarCrucero(i, cruise);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(agencia.MostrarCruceros()[i]);
            }

        }
    }
}
