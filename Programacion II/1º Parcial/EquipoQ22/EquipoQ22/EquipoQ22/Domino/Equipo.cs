using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoQ22.Domino
{
    public class Equipo
    {
        public Equipo()
        {
            Jugadores = new List<Jugador>();
        }
        public string Pais { get; set; }

        public string DirectorTecnico { get; set; }

        public List<Jugador> Jugadores { get; set; }

        public void AñadirJugadores(Jugador jugador)
        {
            Jugadores.Add(jugador);

        }

        public void QuitarJugadores(DataGridView dgvDetalles,Label lblTotal )
        {
            for (int i = 0; i < dgvDetalles.Rows.Count; i++)
            {

                Jugadores.RemoveAt(dgvDetalles.Rows[i].Cells[i].RowIndex);

                dgvDetalles.Rows.RemoveAt(dgvDetalles.Rows[i].Cells[i].RowIndex);

              

            }

            lblTotal.Text = "Total de Jugadores:  " + (dgvDetalles.Rows.Count).ToString();


        }


    }
}
