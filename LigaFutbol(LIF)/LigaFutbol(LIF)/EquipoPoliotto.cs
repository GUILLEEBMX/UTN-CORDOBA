using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LigaFutbol_LIF_
{
    class EquipoPoliotto
    {
        
            private string denominacion;
            private string categoria;
            private Jugador[] personas; // un equipo se compone de jugadores

            public EquipoPoliotto(int cantidad)
            {
                denominacion = String.Empty;
                categoria = String.Empty;
                personas = new Jugador[cantidad]; // inicializar el vector de jugadores con un tamaño fijo

            }


            public EquipoPoliotto(int cantidad, string denom, string cat)
            {
                denominacion = denom;
                categoria = cat;
                personas = new Jugador[cantidad]; // inicializar el vector de jugadores con un tamaño fijo

            }

            public string Denominacion
            {
                get { return denominacion; }
                set { denominacion = value; }
            }

            public string Categoria
            {
                get { return categoria; }
                set { categoria = value; }
            }

            public void AgregarJugadores(Jugador oJugador)
            {
                for (int i = 0; i < personas.Length; i++)
                {
                    if (personas[i] == null)
                    {
                        personas[i] = oJugador;
                        break;
                    }
                }
            }

            public override string ToString()
            {
                string aux = "Equipo: " + denominacion + "\nCategoria: " + categoria + "\n\n";

                for (int i = 0; i < personas.Length; i++)
                {
                    if (personas[i] != null) //esto es fundamental para procesar el vector de objetos!!!
                    {
                        aux += personas[i].ToString() + "\n";
                    }
                }

                return aux;
            }

        public int ListadoSuspendidos()
        {
            int contadorSuspendidos = 0;

            for (int i = 0; i < personas.Length; i++)
            {
                if (personas[i].EstaSuspendido() == true)
                {
                    contadorSuspendidos++;
                }

            }

            return contadorSuspendidos;
        }






    }


}

