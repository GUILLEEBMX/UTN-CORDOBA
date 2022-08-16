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

                if (i % 2 ==  0)
                {
                    Jugador gamer = new Jugador("Carlos", "Tevez", "23/11/1994", "0-", "Delantero", true, r.Next(1,10));
                    team.AgregarJugador(gamer, i);

                }
                else
                {
                  

                    Jugador player = new Jugador("Leonel", "Messi", "22/10/1993", "A+", "MEDIO CAMPISTA", false, 0);
                    team.AgregarJugador(player, i);


                }



            }

            Console.WriteLine("\nEL LISTADO TOTAL DE JUGADORES ES:\n");

            for (int i = 0; i < cantidadJugadores; i++)
            {

                Console.WriteLine(team.ListarJugadores()[i].Nombre + " " + team.ListarJugadores()[i].Apellido);

                
            }


            Console.WriteLine("\nEL LISTADO DE JUGADORES SUSPENDIDOS ES:\n");

            for (int i = 0; i < cantidadJugadores; i++)
            {

                if (team.ListadoSuspendidos()[i] != null)
                {
                    Console.WriteLine(team.ListadoSuspendidos()[i].Nombre + " " +
                                      team.ListadoSuspendidos()[i].Apellido);
                }

            }


            Console.WriteLine("\nEL MEJOR MEDIOCAMPISTA ES:\n");

            Console.WriteLine(team.ListarJugadores()[team.MostrarMejorMedioCampista()].Nombre);

            Console.WriteLine("\nEL PROMEDIO DE VALORACION DE TODO EL EQUIPO ES DE:" + " " + team.PromedioValoracion());

            if (team.MostrarMejorDelantero() == null)
            {
                Console.WriteLine("NO SE INGRESO NINGUN DELANTERO...");
            }
            else
            {
                Console.WriteLine("\n EL MEJOR DELANTERO ES:" + team.MostrarMejorDelantero().ToString());

            }

            


            



           
            
             

            
            

            



















        }
    }
}
