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
              
                Jugador player = new Jugador("Leonel", "Messi", "22/10/1993","A+","Delantero",false,r.Next(1,10));
                team.AgregarJugador(player, i);
            }

            Console.WriteLine("EL LISTADO DE JUGADORES SUSPENDIDOS ES:");
            Console.WriteLine(team.ListadoSuspendidos());
            
        

          




                






        }
    }
}
