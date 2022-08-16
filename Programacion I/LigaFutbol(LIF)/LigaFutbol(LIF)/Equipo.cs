using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaFutbol_LIF_
{
    class Equipo
    {
        private int cantidadJugadores;
        private Jugador [] jugadores;
        
        public Equipo(int cantidadJugadores)
        {
            this.cantidadJugadores = cantidadJugadores;
            jugadores = new Jugador[cantidadJugadores];
        }

        public int CantidadJugadores
        {
            get { return cantidadJugadores; }
            set { cantidadJugadores = value; }
        }

        public void AgregarJugador (Jugador jugador, int index)
        {
            if (index > cantidadJugadores)
            {
                throw new Exception("OUT OF INDEX...");
            }
            jugadores[index] = jugador;

        }   

        public Jugador [] ListarJugadores()
        {
            return jugadores;
        }

        public Jugador[] ListadoSuspendidos()
        {
            Jugador[] listadoSuspendidos = new Jugador[cantidadJugadores];

            for (int i = 0; i < jugadores.Length; i++)
            {

                if (jugadores[i] != null && jugadores[i].EstaSuspendido() == true)
                {
                    listadoSuspendidos[i] = jugadores[i];

                }

            }

            return listadoSuspendidos;


        }

        public Jugador MostrarMejorDelantero()
        {
            Jugador bestPlayer = null;
            

            for (int i = 0; i < jugadores.Length; i++)
            {
                if (jugadores[i].Posicion == "Delantero" && bestPlayer == null)
                {
                    bestPlayer = jugadores[i];
                }

                if (jugadores[i].Posicion == "Delantero" && jugadores[i].Valoracion() > bestPlayer.Valoracion())
                {
                    bestPlayer = jugadores[i];
                }

              
            }

            return bestPlayer;
            

            

        }


        public int MostrarMejorMedioCampista ()
        {
            int posicion = 0;
            for (int i = 0; i < jugadores.Length; i++)
            {
                if (jugadores[i] != null && jugadores[i].Posicion == "MEDIO CAMPISTA" && jugadores[i].Valoracion() == 10 && jugadores[i].Lesionado == false)
                {
                    posicion = i;
                } 
               
            }

            return posicion;
                 
        }



        public bool ExisteJugador()
        {
            bool auxiliar = true;

            for (int i = 0; i <jugadores.Length; i++)
            {
                if (jugadores[i] != null)
                {
                    auxiliar = true;
                }
                else
                {
                    auxiliar = false;
                }
            }

            return auxiliar;
        
        }

        public double PromedioValoracion()
        {
            int promedioValoracion = 0;

            for (int i = 0; i < jugadores.Length; i++)
            {
             
               promedioValoracion = jugadores[i].Valoracion() + promedioValoracion;
                
            }

            double promedioFinal = promedioValoracion / cantidadJugadores;

            return promedioFinal;

        }   

       




    }
}
