using EquipoQ22.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoQ22.Validators
{
    public class  FormValidator : IFormValidatorServices

    {
        public bool ValidarPosiciones(DataGridView dgvDetalles, ComboBox cboPosiciones,ComboBox cboPersonas)
        {
            bool flag = false;


            for (int i = 0; i < dgvDetalles.Rows.Count; i++)
            {
                if (dgvDetalles.Rows[i].Cells[1].Value != null)
                {
                    if (dgvDetalles.Rows[i].Cells[3].Value.ToString().Equals(cboPosiciones.Text)
                        && dgvDetalles.Rows[i].Cells[1].Value.ToString().Equals(cboPersonas.Text))
                    {
                        flag = true;
                        break;
                    }

                }

            }

            return flag;

        }

        public bool ValidarCampos (TextBox textboxt)
        {
            if (string.IsNullOrEmpty(textboxt.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidarCantidadJugadores (DataGridView dgvDetalles)
        {
            if (dgvDetalles.Rows.Count < 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public  bool ValidatorCombos(ComboBox combo)
        {
            if(combo.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
