using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoQ22.Services
{
    public interface IFormValidatorServices
    {
        bool ValidarPosiciones(DataGridView dgvDetalles, ComboBox cboPosiciones,ComboBox cboPersonas);
        bool ValidarCantidadJugadores (DataGridView dgvDetalles);

        bool ValidatorCombos(ComboBox combo);

        bool ValidarCampos(TextBox textboxt);
    }
}
