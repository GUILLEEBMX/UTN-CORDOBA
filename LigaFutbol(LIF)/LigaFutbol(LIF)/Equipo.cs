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
                throw new Exception("OUT OF INDEX");
            }
            jugadores[index] = jugador;

        }   

        public int ListadoSuspendidos()
        {
            int contadorSuspendidos = 0;

            for (int i = 0; i < jugadores.Length; i++)
            {
                if (jugadores[i].EstaSuspendido() == true)
                {
                    contadorSuspendidos++;
                }

            }

            

            return contadorSuspendidos;
        }



    }
}
