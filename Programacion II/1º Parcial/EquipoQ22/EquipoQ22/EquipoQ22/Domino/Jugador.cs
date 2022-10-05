using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoQ22.Domino
{
    public class Jugador
    {
        public Jugador()
        {
            Persona = new Persona();
        }
        public Persona Persona { get; set; }
        public int Camiseta { get; set; }
        public string Posicion { get; set; }

    }
}
