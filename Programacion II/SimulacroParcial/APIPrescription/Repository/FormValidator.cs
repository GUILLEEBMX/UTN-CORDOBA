using APIPrescription.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIPrescription.Repository
{
    public class FormValidator : IFormValidatorService
    {
        public bool ValidateIngredients(DataGridView dgvPrescription,ComboBox cboIngredients)
        {
            bool flag = false; 


            for (int i = 0; i < dgvPrescription.Rows.Count; i++)
            {
                if(dgvPrescription.Rows[i].Cells[1].Value != null)
                {
                    if (dgvPrescription.Rows[i].Cells[1].Value.ToString().Equals(cboIngredients.Text))
                    {
                        flag = true;
                        break;
                    }

                }

            }

            return flag;

        }


        public bool ValidateAmountIngredients(DataGridView dgvPrescription)
        {
            if(dgvPrescription.Rows.Count < 4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidatorOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                MessageBox.Show("ONLY NUMBERS...");
                e.Handled = true;
            }

        }

        public bool ValidateFields(TextBox textboxt)
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
    }
}
