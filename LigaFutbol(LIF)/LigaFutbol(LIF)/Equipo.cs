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
        private Jugador jugador;

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

        public int ListadoSuspendidos(int index, int faltas)
        {
            int contadorSuspendidos = 0;
          
            if (jugadores[index].EstaSuspendido(faltas) == true)
            {
               contadorSuspendidos++;
            }

            return contadorSuspendidos;
        }



    }
}
