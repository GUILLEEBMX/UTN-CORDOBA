using System;

namespace LigaFutbol_LIF_
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("INGRESA LA CANTIDAD DE JUGADORES...");
            int cantidadJugadores = int.Parse(Console.ReadLine());

            Equipo team = new Equipo(cantidadJugadores);
            Random r = new Random();

            for (int i = 0; i < cantidadJugadores; i++)
            {
                int x = r.Next(1, 10);
                x.ToString();
                Jugador player = new Jugador("Leonel", "Messi", "22/10/1993","A+","Delantero",false,0);
                team.AgregarJugador(player, i);
            }

            Console.WriteLine("EL LISTADO DE JUGADORES SUSPENDIDOS ES:");
            int faltas = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadJugadores; i++)
            {

            




            }
            

      

          




                






        }
    }
}
